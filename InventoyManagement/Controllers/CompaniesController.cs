using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoyManagement.Models;

namespace InventoyManagement.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly RunModel _context;

        public CompaniesController(RunModel context)
        {
            _context = context;
        }

        // GET: Companies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Companies.ToListAsync());
        }

        // GET: Companies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companiesModel = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyRegistrationID == id);
            if (companiesModel == null)
            {
                return NotFound();
            }

            return View(companiesModel);
        }

        // GET: Companies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyRegistrationID,CompanyName,CompanyAdd1,CompanyAdd2,CompanyAdd3,CompanyAdd4,CompanyCity,CompanyState,CompanyCounty,CompanyEmail,CompanyTelOffice,DateCreated,DateUpdated,Status")] CompaniesModel companiesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companiesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companiesModel);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companiesModel = await _context.Companies.FindAsync(id);
            if (companiesModel == null)
            {
                return NotFound();
            }
            return View(companiesModel);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyRegistrationID,CompanyName,CompanyAdd1,CompanyAdd2,CompanyAdd3,CompanyAdd4,CompanyCity,CompanyState,CompanyCounty,CompanyEmail,CompanyTelOffice,DateCreated,DateUpdated,Status")] CompaniesModel companiesModel)
        {
            if (id != companiesModel.CompanyRegistrationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companiesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompaniesModelExists(companiesModel.CompanyRegistrationID))
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
            return View(companiesModel);
        }

        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companiesModel = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyRegistrationID == id);
            if (companiesModel == null)
            {
                return NotFound();
            }

            return View(companiesModel);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companiesModel = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(companiesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompaniesModelExists(string id)
        {
            return _context.Companies.Any(e => e.CompanyRegistrationID == id);
        }
    }
}
