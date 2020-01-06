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
 * YKPatientTreatmentController
 * Purpose : To handle the data with the Patient Treatment Model and View
 * 
 * Made by Yunice Kim(7940406)
 * 
 * Revision History
 *  Oct282, 2019   Create
 */
namespace YKPatients.Controllers
{
    public class YKPatientTreatmentController : Controller
    {
        private readonly PatientsContext _context;

        public YKPatientTreatmentController(PatientsContext context)
        {
            _context = context;
        }

        // GET: YKPatientTreatment
        public async Task<IActionResult> Index(string patientDiagnosisId, int patientId, string diagnosisName, string lastName, string firstName)
        {

            if (patientDiagnosisId != null)
            {
                HttpContext.Session.SetString("patientDiagnosisId", patientDiagnosisId);
                HttpContext.Session.SetString("diagnosisName", diagnosisName);
                HttpContext.Session.SetString("lastName", lastName);
                HttpContext.Session.SetString("firstName", firstName);
                HttpContext.Session.SetString("patientId", patientId.ToString());

                Response.Cookies.Append("patientDiagnosisId", patientDiagnosisId);
                Response.Cookies.Append("diagnosisName", diagnosisName);
                Response.Cookies.Append("lastName", lastName);
                Response.Cookies.Append("firstName", firstName);
                Response.Cookies.Append("patientId", patientId.ToString());
            }
            else if (Request.Cookies["patientDiagnosisId"] != null)
            {
                patientDiagnosisId = Request.Cookies["patientDiagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
                patientId = Convert.ToInt32(Request.Cookies["patientId"]);
            }
            else if (HttpContext.Session.GetString("diagnosisId") != null)
            {
                patientDiagnosisId = HttpContext.Session.GetString("patientDiagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");
                patientId = Convert.ToInt32(HttpContext.Session.GetInt32("patientId"));
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["patientDiagnosisId"] = patientDiagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;


            var patientsContext = _context.PatientTreatment.Include(p => p.PatientDiagnosis)
                                                            .Include(p => p.Treatment)
                                                            .Where(p => p.PatientDiagnosis.PatientDiagnosisId.ToString() == patientDiagnosisId)
                                                            .Where(p => p.PatientDiagnosis.PatientId == patientId)
                                                            .OrderByDescending(p => p.DatePrescribed);
            return View(await patientsContext.ToListAsync());
        }

        // GET: YKPatientTreatment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            string diagnosisId;
            string diagnosisName;
            string lastName;
            string firstName;

            if (HttpContext.Session.GetString("diagnosisId") != null)
            {
                diagnosisId = HttpContext.Session.GetString("diagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");
            }
            else if (Request.Cookies["diagnosisId"] != null)
            {
                diagnosisId = Request.Cookies["diagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["diagnosisId"] = diagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;

            if (id == null)
            {
                return NotFound();
            }

            var patientTreatment = await _context.PatientTreatment
                .Include(p => p.PatientDiagnosis)
                .Include(p => p.Treatment)
                .FirstOrDefaultAsync(m => m.PatientTreatmentId == id);
            if (patientTreatment == null)
            {
                return NotFound();
            }

            return View(patientTreatment);
        }

        // GET: YKPatientTreatment/Create
        public IActionResult Create()
        {
            string patientDiagnosisId;
            string diagnosisName;
            int patientId;
            string lastName;
            string firstName;

            if (HttpContext.Session.GetString("patientDiagnosisId") != null)
            {
                patientDiagnosisId = HttpContext.Session.GetString("patientDiagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                patientId = Convert.ToInt32(HttpContext.Session.GetInt32("patientId"));
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");
            }
            else if (Request.Cookies["diagnosisId"] != null)
            {
                patientDiagnosisId = Request.Cookies["diagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                patientId = Convert.ToInt32(Request.Cookies["diagnosisId"]);
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["patientDiagnosisId"] = patientDiagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;
            ViewData["patientId"] = patientId;
            //to show treatments related to diagnosis name
            var dignosisValue = _context.Diagnosis.Where(m => m.Name == diagnosisName).FirstOrDefault();
            if (dignosisValue != null)
            {
                ViewData["TreatmentId"] = new SelectList(_context.Treatment.Where(m => m.DiagnosisId == dignosisValue.DiagnosisId)
                                                                        .OrderBy(m => m.Name), "TreatmentId", "Name");
            }
            else
            {
                TempData["message"] = "There is an error of the diagnosis id from the Diagnosis Table";
                return RedirectToAction("Index", "YKPatientTreatment");
            }

            return View();
        }

        // POST: YKPatientTreatment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientTreatmentId,TreatmentId,DatePrescribed,Comments,PatientDiagnosisId")] PatientTreatment patientTreatment)
        {
            string patientDiagnosisId;
            string diagnosisName;
            string lastName;
            string firstName;
            int patientId;

            if (HttpContext.Session.GetString("patientDiagnosisId") != null)
            {
                patientDiagnosisId = HttpContext.Session.GetString("patientDiagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                patientId = Convert.ToInt32(HttpContext.Session.GetInt32("patientId"));
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");

            }
            else if (Request.Cookies["patientDiagnosisId"] != null)
            {
                patientDiagnosisId = Request.Cookies["patientDiagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                patientId = Convert.ToInt32(Request.Cookies["diagnosisId"]);
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["patientDiagnosisId"] = patientDiagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;

            if (ModelState.IsValid)
            {
                _context.Add(patientTreatment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            TempData["message"] = "There is an error for entering inputs";

            //to show treatments related to diagnosis name
            var dignosisValue = _context.Diagnosis.Where(m => m.Name == diagnosisName).FirstOrDefault();
            if (dignosisValue != null)
            {
                ViewData["TreatmentId"] = new SelectList(_context.Treatment.Where(m => m.DiagnosisId == dignosisValue.DiagnosisId)
                                                                        .OrderBy(m => m.Name), "TreatmentId", "Name");
            }
            else
            {
                TempData["message"] = "There is an error of the diagnosis id from the Diagnosis Table";
                return RedirectToAction("Index", "YKPatientTreatment");
            }

            return View(patientTreatment);
        }

        // GET: YKPatientTreatment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            string patientDiagnosisId;
            string diagnosisName;
            string lastName;
            string firstName;

            if (HttpContext.Session.GetString("patientDiagnosisId") != null)
            {
                patientDiagnosisId = HttpContext.Session.GetString("patientDiagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");
            }
            else if (Request.Cookies["patientDiagnosisId"] != null)
            {
                patientDiagnosisId = Request.Cookies["patientDiagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["patientDiagnosisId"] = patientDiagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;

            if (id == null)
            {
                TempData["message"] = "please choose a treatment";
                return RedirectToAction("Index", "YKPatientTreatment");
                //return NotFound();
            }

            var patientTreatment = await _context.PatientTreatment.FindAsync(id);
            if (patientTreatment == null)
            {
                TempData["message"] = "There is no treatment information chosen on the file";
                return RedirectToAction("Index", "YKPatientTreatment");
                //return NotFound();
            }

            //to show treatments related to diagnosis name
            var dignosisValue = _context.Diagnosis.Where(m => m.Name == diagnosisName).FirstOrDefault();
            if (dignosisValue != null)
            {
                ViewData["TreatmentId"] = new SelectList(_context.Treatment.Where(m => m.DiagnosisId == dignosisValue.DiagnosisId)
                                                                        .OrderBy(m => m.Name), "TreatmentId", "Name", patientTreatment.TreatmentId);
            }
            else
            {
                TempData["message"] = "There is an error of the diagnosis id from the Diagnosis Table";
                return RedirectToAction("Index", "YKPatientTreatment");
            }

            return View(patientTreatment);
        }

        // POST: YKPatientTreatment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatientTreatmentId,TreatmentId,DatePrescribed,Comments,PatientDiagnosisId")] PatientTreatment patientTreatment)
        {
            string patientDiagnosisId;
            string diagnosisName;
            string lastName;
            string firstName;

            if (HttpContext.Session.GetString("patientDiagnosisId") != null)
            {
                patientDiagnosisId = HttpContext.Session.GetString("patientDiagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");
            }
            else if (Request.Cookies["patientDiagnosisId"] != null)
            {
                patientDiagnosisId = Request.Cookies["patientDiagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["patientDiagnosisId"] = patientDiagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;

            if (id != patientTreatment.PatientTreatmentId)
            {
                TempData["message"] = "The chosen treatment is not the same as the treatment revised";
                return RedirectToAction("Index", "YKPatientTreatment");
                //return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientTreatment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientTreatmentExists(patientTreatment.PatientTreatmentId))
                    {
                        TempData["message"] = "The treatment is not on the file";
                        return RedirectToAction("Index", "YKPatientTreatment");
                        //return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            //to show treatments related to diagnosis name
            var dignosisValue = _context.Diagnosis.Where(m => m.Name == diagnosisName).FirstOrDefault();
            if (dignosisValue != null)
            {
                ViewData["TreatmentId"] = new SelectList(_context.Treatment.Where(m => m.DiagnosisId == dignosisValue.DiagnosisId)
                                                                        .OrderBy(m => m.Name), "TreatmentId", "Name", patientTreatment.TreatmentId);
            }
            else
            {
                TempData["message"] = "There is an error of the diagnosis id from the Diagnosis Table";
                return RedirectToAction("Index", "YKPatientTreatment");
            }

            return View(patientTreatment);
        }

        // GET: YKPatientTreatment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            string diagnosisId;
            string diagnosisName;
            string lastName;
            string firstName;

            if (HttpContext.Session.GetString("diagnosisId") != null)
            {
                diagnosisId = HttpContext.Session.GetString("diagnosisId");
                diagnosisName = HttpContext.Session.GetString("diagnosisName");
                lastName = HttpContext.Session.GetString("lastName");
                firstName = HttpContext.Session.GetString("firstName");
            }
            else if (Request.Cookies["diagnosisId"] != null)
            {
                diagnosisId = Request.Cookies["diagnosisId"];
                diagnosisName = Request.Cookies["diagnosisName"];
                lastName = Request.Cookies["lastName"];
                firstName = Request.Cookies["firstName"];
            }
            else
            {
                TempData["message"] = "Please select a patient’s diagnosis";
                return RedirectToAction("Index", "YKPatientDiagnosis");
            }

            ViewData["diagnosisId"] = diagnosisId;
            ViewData["lastName"] = lastName;
            ViewData["firstName"] = firstName;
            ViewData["diagnosisName"] = diagnosisName;

            if (id == null)
            {
                TempData["message"] = "Please select a treatment to delete";
                return RedirectToAction("Index", "YKPatientTreatment");

                //return NotFound();
            }

            var patientTreatment = await _context.PatientTreatment
                .Include(p => p.PatientDiagnosis)
                .Include(p => p.Treatment)
                .FirstOrDefaultAsync(m => m.PatientTreatmentId == id);
            if (patientTreatment == null)
            {
                TempData["message"] = "There is no same treatment on the file";
                return RedirectToAction("Index", "YKPatientTreatment");
                //return NotFound();
            }

            return View(patientTreatment);
        }

        // POST: YKPatientTreatment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patientTreatment = await _context.PatientTreatment.FindAsync(id);
            _context.PatientTreatment.Remove(patientTreatment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientTreatmentExists(int id)
        {
            return _context.PatientTreatment.Any(e => e.PatientTreatmentId == id);
        }
    }
}
