using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YKPatients.Models;
/*
 * YKMedicationTypesController
 * Purpose : To handle the data with the Medication Types Model and View
 * 
 * Made by Yunice Kim(7940406)
 * 
 * Revision History
 *  Oct 2, 2019   Create
 */
namespace YKPatients.Controllers
{
    public class YKMedicationsController : Controller
    {
        private readonly PatientsContext _context;

        public YKMedicationsController(PatientsContext context)
        {
            _context = context;
        }

        // GET: YKMedications
        /// <summary>
        /// Get two parameter from the index view of MedicationTypeController 
        /// check the medicationTypeId or session to show the exact list related to medicationTypeId
        /// </summary>
        /// <param name="medicationTypeId"></param>
        /// <param name="medicationTypeName"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int medicationTypeId, string medicationTypeName)
        {
            if (medicationTypeId != 0)
            {
                HttpContext.Session.SetInt32("medicationTypeId", medicationTypeId);
                HttpContext.Session.SetString("medicationTypeName", medicationTypeName);
                Response.Cookies.Append("medicationTypeId", medicationTypeId.ToString());
                Response.Cookies.Append("medicationTypeName", medicationTypeName);
            }
            else if (HttpContext.Session.GetString("medicationTypeId") != null)
            {
                medicationTypeId = Convert.ToInt32(
                    HttpContext.Session.GetInt32("medicationTypeId"));
                medicationTypeName = HttpContext.Session.GetString("medicationTypeName");
            }
            else if (Request.Cookies["medicationTypeId"].ToString() != null)
            {
                medicationTypeId = int.Parse(Request.Cookies["medicatonTypeId"]);
                medicationTypeName = Request.Cookies["medicationTypeName"];
            }
            else
            {
                TempData["Message"] = "Please select a medication type to see its medications";
                return Redirect("/YKMedicationTypes");
            }

            ViewData["medicationTypeId"] = medicationTypeId;
            ViewData["medicationTypeName"] = medicationTypeName;

            var mvcPatientContext = _context.Medication.Where(m => m.MedicationTypeId == medicationTypeId)
                                                        .Include(m => m.MedicationType)
                                                        .OrderBy(m => m.Name).ThenBy(m => m.Concentration);

            return View(await mvcPatientContext.ToListAsync()); 
        }


        // GET: YKMedications/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medication
                .Include(m => m.ConcentrationCodeNavigation)
                .Include(m => m.DispensingCodeNavigation)
                .Include(m => m.MedicationType)
                .FirstOrDefaultAsync(m => m.Din == id);
            if (medication == null)
            {
                return NotFound();
            }

            return View(medication);
        }

        // GET: YKMedications/Create
        public IActionResult Create()
        {
            int medicationTypeId;
            string medicationTypeName;

            if (HttpContext.Session.GetString("medicationTypeId") != null)
            {
                medicationTypeId = Convert.ToInt32(
                    HttpContext.Session.GetInt32("medicationTypeId"));
                medicationTypeName = HttpContext.Session.GetString("medicationTypeName");
            }
            else if (Request.Cookies["medicationTypeId"].ToString() != null)
            {
                medicationTypeId = int.Parse(Request.Cookies["medicatonTypeId"]);
                medicationTypeName = Request.Cookies["medicationTypeName"];
            }
            else
            {
                TempData["Message"] = "Please select a medication type to see its medications";
                return Redirect("/YKMedicationTypes");
            }

            ViewData["medicationTypeId"] = medicationTypeId;
            ViewData["medicationTypeName"] = medicationTypeName;

            //add OrderBy() made by Yunice Kim on Oct 2nd, 2019
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode");
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m=>m.DispensingCode), "DispensingCode", "DispensingCode");
            ViewData["MedicationTypeId"] = new SelectList(_context.MedicationType, "MedicationTypeId", "Name");
            return View();
        }

        // POST: YKMedications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Din,Name,Image,MedicationTypeId,DispensingCode,Concentration,ConcentrationCode")]
                                            Medication medication)
        {
            if (medication.MedicationTypeId == 0)
            {
                TempData["message"] = 
                    "Couldn't get the medication type id from the create web page.";
                return RedirectToAction("Index", "YKMedications");
            }

            //check there is the same Din on the medication table
            Medication existMedication = 
                _context.Medication.SingleOrDefault(m => m.Din == medication.Din);
            if (existMedication != null)
            {
                TempData["message"] = "The Din already exists in the database.";
                return RedirectToAction("Index", "YKMedications");
            }

            if (ModelState.IsValid)
            {
                //check there is the same name, concentration, and concentration code on the medication table
                var existSameContent = _context.Medication.Where(m => m.Name == medication.Name &&
                                                m.Concentration == medication.Concentration &&
                                                m.ConcentrationCode == medication.ConcentrationCode).FirstOrDefault();

                if (existSameContent != null)
                {
                    TempData["message"] = "The same record already exists in the database.";
                    return RedirectToAction("Index", "YKMedications");
                }

                _context.Add(medication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //add OrderBy() made by Yunice Kim on Oct 2nd, 2019 
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode", medication.ConcentrationCode);
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode", medication.DispensingCode);
            ViewData["MedicationTypeId"] = new SelectList(_context.MedicationType, "MedicationTypeId", "Name", medication.MedicationTypeId);
            return View(medication);
        }

        // GET: YKMedications/Edit/5

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                TempData["message"] = "Cannot get the medication type id from the previous page.";
                return RedirectToAction("Index", "YKMedications");                
            }

            var medication = await _context.Medication.FindAsync(id);
            if (medication == null)
            {
                TempData["message"] = "Cannot find the selected medication record from the database.";
                return RedirectToAction("Index", "YKMedications");

            }
            //add OrderBy() made by Yunice Kim on Oct 2nd, 2019 
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode", medication.ConcentrationCode);
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode", medication.DispensingCode);
            ViewData["MedicationTypeId"] = new SelectList(_context.MedicationType, "MedicationTypeId", "Name", medication.MedicationTypeId);

            return View(medication);
        }

        // POST: YKMedications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Din,Name,Image,MedicationTypeId,DispensingCode,Concentration,ConcentrationCode")] Medication medication)
        {
            if (id != medication.Din)
            {
                TempData["message"] =
                        "Couldn't get the medication Din from the Edit web page.";
                return RedirectToAction("Index", "YKMedications");

            }

            if (ModelState.IsValid)
            {
                var existSameContent = _context.Medication.Where(m => m.Name == medication.Name &&
                                m.Concentration == medication.Concentration &&
                                m.ConcentrationCode == medication.ConcentrationCode).FirstOrDefault();

                //check there is the same name, concentration, and concentration code on the medication table
                if (existSameContent != null)
                {
                    TempData["message"] = "The same record already exists in the database.";
                    return RedirectToAction("Index", "YKMedications");
                }

                try
                {
                    _context.Update(medication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicationExists(medication.Din))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //add OrderBy() made by Yunice Kim on Oct 2nd, 2019 
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode", medication.ConcentrationCode);
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode", medication.DispensingCode);
            ViewData["MedicationTypeId"] = new SelectList(_context.MedicationType, "MedicationTypeId", "Name", medication.MedicationTypeId);
            return View(medication);
        }
        

        // GET: YKMedications/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medication
                .Include(m => m.ConcentrationCodeNavigation)
                .Include(m => m.DispensingCodeNavigation)
                .Include(m => m.MedicationType)
                .FirstOrDefaultAsync(m => m.Din == id);
            if (medication == null)
            {
                return NotFound();
            }

            return View(medication);
        }

        // POST: YKMedications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var medication = await _context.Medication.FindAsync(id);
            _context.Medication.Remove(medication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicationExists(string id)
        {
            return _context.Medication.Any(e => e.Din == id);
        }
    }
}
