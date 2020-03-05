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
    public class BrandsController : Controller
    {
        private readonly RunModel _context;

        public BrandsController(RunModel context)
        {
            _context = context;
        }

        // GET: Brands
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }

        // GET: Brands/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandsModel = await _context.Brands
                .FirstOrDefaultAsync(m => m.BrandID == id);
            if (brandsModel == null)
            {
                return NotFound();
            }

            return View(brandsModel);
        }

        // GET: Brands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrandID,BrandName,DateCreated,DateUpdate,BrandStatus")] BrandsModel brandsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brandsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brandsModel);
        }

        // GET: Brands/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandsModel = await _context.Brands.FindAsync(id);
            if (brandsModel == null)
            {
                return NotFound();
            }
            return View(brandsModel);
        }

        // POST: Brands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BrandID,BrandName,DateCreated,DateUpdate,BrandStatus")] BrandsModel brandsModel)
        {
            if (id != brandsModel.BrandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brandsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandsModelExists(brandsModel.BrandID))
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
            return View(brandsModel);
        }

        // GET: Brands/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandsModel = await _context.Brands
                .FirstOrDefaultAsync(m => m.BrandID == id);
            if (brandsModel == null)
            {
                return NotFound();
            }

            return View(brandsModel);
        }

        // POST: Brands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var brandsModel = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(brandsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrandsModelExists(string id)
        {
            return _context.Brands.Any(e => e.BrandID == id);
        }
    }
}
