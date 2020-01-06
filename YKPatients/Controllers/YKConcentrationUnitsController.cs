using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YKPatients.Models;
/*
 * YKConcentrationUnitsController
 * Purpose : To handle the data with the Concentration Unit Model and View
 * 
 * Made by Yunice Kim(7940406)
 * 
 * Revision History
 *  Sept 17, 2019   Create
 */
namespace YKPatients.Controllers
{
    public class YKConcentrationUnitsController : Controller
    {
        private readonly PatientsContext _context;

        public YKConcentrationUnitsController(PatientsContext context)
        {
            _context = context;
        }

        // GET: YKConcentrationUnits
        //get record list on the database of Concentration Units
        public async Task<IActionResult> Index()
        {
            ViewData["section"] = "Concentration Units";

            return View(await _context.ConcentrationUnit.ToListAsync());
        }

        // GET: YKConcentrationUnits/Details/5
        //get a record's detail of id on the database of Concentration Units
        public async Task<IActionResult> Details(string id)
        {
            ViewData["section"] = "Concentration Units";

            if (id == null)
            {
                return NotFound();
            }

            var concentrationUnit = await _context.ConcentrationUnit
                .FirstOrDefaultAsync(m => m.ConcentrationCode == id);
            if (concentrationUnit == null)
            {
                return NotFound();
            }

            return View(concentrationUnit);
        }

        // GET: YKConcentrationUnits/Create
        //insert a record of id on the database of Concentration Units
        public IActionResult Create()
        {
            ViewData["section"] = "Concentration Units";

            return View();
        }

        // POST: YKConcentrationUnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConcentrationCode")] ConcentrationUnit concentrationUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concentrationUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concentrationUnit);
        }

        // GET: YKConcentrationUnits/Edit/5
        //edit a record of id on the database of Concentration Units
        public async Task<IActionResult> Edit(string id)
        {
            ViewData["section"] = "Concentration Units";

            if (id == null)
            {
                return NotFound();
            }

            var concentrationUnit = await _context.ConcentrationUnit.FindAsync(id);
            if (concentrationUnit == null)
            {
                return NotFound();
            }
            return View(concentrationUnit);
        }

        // POST: YKConcentrationUnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ConcentrationCode")] ConcentrationUnit concentrationUnit)
        {
            if (id != concentrationUnit.ConcentrationCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concentrationUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcentrationUnitExists(concentrationUnit.ConcentrationCode))
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
            return View(concentrationUnit);
        }

        // GET: YKConcentrationUnits/Delete/5
        //delete a record of id on the database of Concentration Units
        public async Task<IActionResult> Delete(string id)
        {
            ViewData["section"] = "Concentration Units";

            if (id == null)
            {
                return NotFound();
            }

            var concentrationUnit = await _context.ConcentrationUnit
                .FirstOrDefaultAsync(m => m.ConcentrationCode == id);
            if (concentrationUnit == null)
            {
                return NotFound();
            }

            return View(concentrationUnit);
        }

        // POST: YKConcentrationUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var concentrationUnit = await _context.ConcentrationUnit.FindAsync(id);
            _context.ConcentrationUnit.Remove(concentrationUnit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcentrationUnitExists(string id)
        {
            ViewData["section"] = "Concentration Units";

            return _context.ConcentrationUnit.Any(e => e.ConcentrationCode == id);
        }
    }
}
