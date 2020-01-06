using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace YKClassLibrary
{
    public static class YKValidations
    {
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

                    if (i < eachWords.Length-1)
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

        public static string YKExtractDigits(string inputedString)
        {
            string extractedDigits = "";

            for (int i = 0; i < inputedString.Length; i++)
            {
                if (Char.IsDigit(inputedString[i]))
                    extractedDigits += inputedString[i];
            }
            return extractedDigits;
        }

        public static bool YKPostalCodeValidation(string inputedString)
        {
            bool isRight = false;
            inputedString = inputedString.Trim();

            Regex rxPostalCode = new Regex(
                @"^[ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ] ?\d[ABCEGHJKLMNPRSTVWXYZ]\d$",
                RegexOptions.IgnoreCase);

            if (rxPostalCode.IsMatch(inputedString))
            {
                isRight = true;
            }
            return isRight;
        }

        public static string YKPostalCodeFormat(string inputedString)
        {
            string rtnStr = "";
            inputedString = inputedString.Trim().ToUpper();

            string[] strArray = inputedString.Split(' ');

            if (strArray.Length == 1)
            {
                rtnStr = inputedString.Insert(3, " ");
            }
            else
            {
                rtnStr = inputedString;
            }
            return rtnStr;
        }

        public static bool YKZipCodeValidation(ref string inputedString)
        {
            if (inputedString == null || inputedString == "")
            {
                inputedString = "";
                return true;
            }
            else
            {
                inputedString = YKExtractDigits(inputedString);

                if (inputedString.Length == 5)
                {
                    return true;
                }
                else if (inputedString.Length == 9)
                {
                    string tempZipCode = "";
                    for (int i = 0; i < inputedString.Length; i++)
                    {
                        tempZipCode += inputedString[i];
                        if (i == 4)
                        {
                            tempZipCode += "-";
                        }
                    }
                    inputedString = tempZipCode;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool YKOhipValidation(string inputedString)
        {
            inputedString = inputedString.Trim().ToUpper();

            Regex rxPostalCode = new Regex(
                @"^\d{4}-?\d{3}-?\d{3}-?[A-Za-z]{2}$",
                RegexOptions.IgnoreCase);

            if (rxPostalCode.IsMatch(inputedString))
            {
                return true;
            }
            return false;
        }

        public static string YKOhipFormat(string inputedString)
        {
            string fomattedOhip = "";
            inputedString = inputedString.Trim().ToUpper();

            for (int i = 0; i < inputedString.Length; i++)
            {
                fomattedOhip += inputedString[i].ToString();

                if (i == 3 || i == 6 || i == 9)
                {
                    fomattedOhip += "-";
                }
            }
            return fomattedOhip;
        }

        public static string YKHomePhoneFormat(string homePhone)
        {
            string fomattedHomePhone = "";

            for (int i = 0; i < homePhone.Length; i++)
            {
                fomattedHomePhone += homePhone[i].ToString();

                if (i == 2 || i == 5)
                {
                    fomattedHomePhone += "-";
                }
            }
            return fomattedHomePhone;
            //return Convert.ToInt64(homePhone).ToString("###-###-####");
        }
    }
}
