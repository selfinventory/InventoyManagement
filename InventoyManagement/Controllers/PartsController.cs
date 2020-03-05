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
    public class PartsController : Controller
    {
        private readonly RunModel _context;

        public PartsController(RunModel context)
        {
            _context = context;
        }

        // GET: Parts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parts.ToListAsync());
        }

        // GET: Parts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partsModel = await _context.Parts
                .FirstOrDefaultAsync(m => m.PartsID == id);
            if (partsModel == null)
            {
                return NotFound();
            }

            return View(partsModel);
        }

        // GET: Parts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartsID,PartsDesc,PartsQty,PartsPrice,PartsSellPrice,PartsManufactureYear,DateCreated,DateUpdate,PartsStatus")] PartsModel partsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partsModel);
        }

        // GET: Parts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partsModel = await _context.Parts.FindAsync(id);
            if (partsModel == null)
            {
                return NotFound();
            }
            return View(partsModel);
        }

        // POST: Parts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PartsID,PartsDesc,PartsQty,PartsPrice,PartsSellPrice,PartsManufactureYear,DateCreated,DateUpdate,PartsStatus")] PartsModel partsModel)
        {
            if (id != partsModel.PartsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartsModelExists(partsModel.PartsID))
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
            return View(partsModel);
        }

        // GET: Parts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partsModel = await _context.Parts
                .FirstOrDefaultAsync(m => m.PartsID == id);
            if (partsModel == null)
            {
                return NotFound();
            }

            return View(partsModel);
        }

        // POST: Parts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var partsModel = await _context.Parts.FindAsync(id);
            _context.Parts.Remove(partsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartsModelExists(string id)
        {
            return _context.Parts.Any(e => e.PartsID == id);
        }
    }
}
