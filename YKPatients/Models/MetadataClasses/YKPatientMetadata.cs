using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using YKClassLibrary;
/*
 * YKPatientTreatmentController
 * Purpose : To handle the data with the Patient Metadata Model and Validation of Class library
 * 
 * Made by Yunice Kim(7940406)
 * 
 * Revision History
 *  Nov 20, 2019 Created
 */
namespace YKPatients.Models
{
    [ModelMetadataType(typeof(YKPatientMetadata))]
    public partial class Patient : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            PatientsContext _context = new PatientsContext();

            //c.Non-blank firstName, lastName and gender are required
            FirstName = YKCapitalize(FirstName);
            if (FirstName == "" )
            {
                yield return new ValidationResult("First name cannot be empty or just blanks",
                                                    new[] { nameof(FirstName) });
            }

            LastName = YKValidations.YKCapitalize(LastName);
            if (LastName == "")
            {
                yield return new ValidationResult("Last name cannot be empty or just blanks",
                                                    new[] { nameof(LastName) });
            }

            //Capitalise address, city and gender
            if (Address != null)
            {
                Address = YKValidations.YKCapitalize(Address);
            }

            if (City != null )
            {
                City = YKValidations.YKCapitalize(City);
            }

            //If provinceCode is not empty or null,
            if (ProvinceCode != null)
            {
                // force it to upper case 
                ProvinceCode = ProvinceCode.Trim().ToUpper();

                //  i.Validate it by fetching its record from the database … error if not found
                var provinceCode = _context.Province.Where(m => m.ProvinceCode == ProvinceCode).Any();

                if (!provinceCode)
                {
                    yield return new ValidationResult("Province Code is not on file",
                                        new[] { nameof(ProvinceCode) });
                }
                else
                {
                    if (PostalCode == null)
                    {
                        yield return new ValidationResult("Postal Code is needed when Province Code is given",
                                            new[] { nameof(PostalCode) });
                    }
                }
            }
            //f.postalCode is conditionally optional but, if provided:
            if (PostalCode != null)
            {
                //i.Produce an error if provinceCode is invalid / missing … it’s required to edit a postal/ zip code
                if (ProvinceCode == null)
                {
                    yield return new ValidationResult("Province Code is needed when Postal Code is given.",
                                                        new[] { nameof(ProvinceCode) });
                }
                else
                {
                    var countryCode = _context.Province.Where(m => m.ProvinceCode == ProvinceCode).SingleOrDefault();
                    if (countryCode != null)
                    {
                        //ii.If provinceCode indicates the patient is in Canada, 
                        //   verify that the first letter of the postalCode is correct for that province.  
                        if (countryCode.CountryCode == "CA")
                        {
                            if (YKValidations.YKPostalCodeValidation(PostalCode))
                            {
                                PostalCode = YKValidations.YKPostalCodeFormat(PostalCode);
                            }
                            else
                            {
                                yield return new ValidationResult("The format of the postalCode is not correct for that province.",
                                                                    new[] { nameof(PostalCode) });
                            }
                        }
                        else if (countryCode.CountryCode == "US")
                        {
                            //iii.Validate and format the postal / zip code using the relevant method(s) in your XXValidations Class
                            //   (error if provinceCode is invalid / missing).
                            string postalCode = PostalCode;
                            if (YKValidations.YKZipCodeValidation(ref postalCode))
                            {
                                PostalCode = postalCode;
                            }
                            else
                            {
                                yield return new ValidationResult("The format of the postalCode is not correct for that province.",
                                                                    new[] { nameof(PostalCode) });
                            }
                        }
                        else
                        {
                            //If not, produce a pertinent error message for both fields.
                            yield return new ValidationResult("The first letter of the postalCode is not correct for that province.",
                                                                new[] { nameof(PostalCode) });
                        }
                    }
                }
            }

            //g.OHIP is optional, but if provided, 
            if (Ohip != null)
            {
                if (YKValidations.YKOhipValidation(Ohip))
                {
                    //shift it to upper case and ensure it’s in this pattern: 1234 - 123 - 123 - XX.
                    Ohip = YKValidations.YKOhipFormat(Ohip); 
                }
                else
                {
                    yield return new ValidationResult("OHIP, if provided, must match pattern: 1234-123-123-XX",
                                                        new[] { nameof(Ohip) });
                }
            }

            //h.homePhone is optional, but if provided:
            //i.It must contain exactly 10 digits(discard punctuation and text like “emergency only”).
            if (HomePhone != null)
            {
                HomePhone = YKValidations.YKExtractDigits(HomePhone.Trim());
                if (HomePhone.Length == 10)
                {
                    string homePhone = HomePhone;
                    //ii.Reformat into dash notation: 519 - 748 - 5220
                    HomePhone = YKValidations.YKHomePhoneFormat(homePhone);
                }
                else
                {
                    yield return new ValidationResult("The phone number's length is not enough or right format",
                                                        new[] { nameof(HomePhone) });
                }
                //iii.Sorry about historical data … we didn’t have edits.They’ll be fixed on their next visit.
            }

            //i.dateOfBirth is optional but, if provided, cannot be in the future
            if (DateOfBirth != null)
            {
                if (DateOfBirth >= DateTime.Now)
                {
                    yield return new ValidationResult("Date of Birth cannot be in the future",
                                                        new[] { nameof(DateOfBirth) });
                }
            }

            //i.If deceased is true, dateOfDeath is required.
            //iii.If dateOfDeath is provided, it cannot be in the future or before dateOfBirth(if it is provided)
            if (Deceased)
            {
                if (DateOfDeath == null )
                {
                    yield return new ValidationResult("Date of Death is needed when Deceased is checked",
                                                            new[] { nameof(DateOfDeath) });
                }
                else if(DateOfBirth == null)
                {
                    yield return new ValidationResult("Date of Birth is needed when Deceased is checked",
                                                            new[] { nameof(DateOfBirth) });
                }
                else if (DateOfDeath >= DateTime.Now)
                {
                    yield return new ValidationResult("Date of Death cannot be in the future",
                                                            new[] { nameof(DateOfDeath) });
                }
                else if (DateOfDeath < DateOfBirth)
                {
                    yield return new ValidationResult("Date of Death cannot be before Date of Birth",
                                                            new[] { nameof(DateOfDeath) });
                }
            }
            else
            {
                //ii.If deceased is false, dateOfDeath must be null.
                if (DateOfDeath != null)
                {
                    yield return new ValidationResult("Date of Death is not needed when Deceased is unchecked",
                                                            new[] { nameof(DateOfDeath) });
                }
            }

            //gender is required and must be “M”, “F” or “X”.  
            //Add a field-validation <span> to display error messages on Create & Edit views.
            Gender = YKValidations.YKCapitalize(Gender);
            if (Gender == null)
            {
                yield return new ValidationResult("Gender cannot be empty or just blanks",
                                                    new[] { nameof(Gender) });
            }
            else
            {
                if (Gender != "M" && Gender != "F" && Gender != "X")
                {
                    yield return new ValidationResult("Gender should be M, F or X",
                                                       new[] { nameof(Gender) });
                }                
            }

            yield return ValidationResult.Success;
        }

        public static string YKCapitalize(string inputedString)
        {
            string capitalizedString = "";

            if (inputedString != null)
            {
                capitalizedString = inputedString.ToLower().Trim();
                string[] eachWords = capitalizedString.Split(" ");
                capitalizedString = "";

                for (int i = 0; i < eachWords.Length; i++)
                {
                    string aWord = eachWords[i];

                    string tempWord = "";
                    for (int j = 0; j < aWord.Length; j++)
                    {
                        if (j == 0)
                        {
                            tempWord += aWord[j].ToString().ToUpper();
                        }
                        else
                        {
                            tempWord += aWord[j];
                        }
                    }

                    if (i < eachWords.Length - 1)
                    {
                        tempWord += " ";
                    }
                    capitalizedString += tempWord;
                }
                return capitalizedString;
            }
            else
            {
                return "";
            }
        }
    }

    public class YKPatientMetadata { 
        
        public int PatientId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "OHIP")]
        public string Ohip { get; set; }
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DateOfBirth { get; set; }
        public bool Deceased { get; set; }
        [Display(Name = "Date of Death")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? DateOfDeath { get; set; }
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }
        public string Gender { get; set; }

        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual ICollection<PatientDiagnosis> PatientDiagnosis { get; set; }
    }
}
