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
    public class ModelController : Controller
    {
        private readonly RunModel _context;

        public ModelController(RunModel context)
        {
            _context = context;
        }

        // GET: Model
        public async Task<IActionResult> Index()
        {
            return View(await _context.ModelParts.ToListAsync());
        }

        // GET: Model/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelPartsModel = await _context.ModelParts
                .FirstOrDefaultAsync(m => m.ModelPartsID == id);
            if (modelPartsModel == null)
            {
                return NotFound();
            }

            return View(modelPartsModel);
        }

        // GET: Model/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Model/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModelPartsID,ModelPartsDesc,ModelPartsYear,ModelPartsCC,DateCreated,DateUpdated")] ModelPartsModel modelPartsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelPartsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelPartsModel);
        }

        // GET: Model/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelPartsModel = await _context.ModelParts.FindAsync(id);
            if (modelPartsModel == null)
            {
                return NotFound();
            }
            return View(modelPartsModel);
        }

        // POST: Model/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ModelPartsID,ModelPartsDesc,ModelPartsYear,ModelPartsCC,DateCreated,DateUpdated")] ModelPartsModel modelPartsModel)
        {
            if (id != modelPartsModel.ModelPartsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modelPartsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModelPartsModelExists(modelPartsModel.ModelPartsID))
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
            return View(modelPartsModel);
        }

        // GET: Model/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelPartsModel = await _context.ModelParts
                .FirstOrDefaultAsync(m => m.ModelPartsID == id);
            if (modelPartsModel == null)
            {
                return NotFound();
            }

            return View(modelPartsModel);
        }

        // POST: Model/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var modelPartsModel = await _context.ModelParts.FindAsync(id);
            _context.ModelParts.Remove(modelPartsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModelPartsModelExists(string id)
        {
            return _context.ModelParts.Any(e => e.ModelPartsID == id);
        }
    }
}
