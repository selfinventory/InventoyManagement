using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoyManagement.Models;
using static InventoyManagement.SystemRef;
using System.ComponentModel.DataAnnotations;

namespace InventoyManagement.Controllers
{
    public class CustomersController : Controller
    {
        private readonly RunModel _context;

        public CustomersController(RunModel context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersModel = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customersModel == null)
            {
                return NotFound();
            }

            return View(customersModel);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
    

            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,CustomerName,CustomerDateOfBirth,CustomerPhoto,CustomerAdd1,CustomerAdd2,CustomerAdd3,CustomerAdd4,CustomerCity,CustomerState,CustomerCounty,CustomerEmail,CustomerTelOffice,CustomerTelMobile,DateCreated,DateUpdated,Status")] CustomersModel customersModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customersModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customersModel);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersModel = await _context.Customers.FindAsync(id);
            if (customersModel == null)
            {
                return NotFound();
            }
            return View(customersModel);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CustomerID,CustomerName,CustomerDateOfBirth,CustomerPhoto,CustomerAdd1,CustomerAdd2,CustomerAdd3,CustomerAdd4,CustomerCity,CustomerState,CustomerCounty,CustomerEmail,CustomerTelOffice,CustomerTelMobile,DateCreated,DateUpdated,Status")] CustomersModel customersModel)
        {
            if (id != customersModel.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customersModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersModelExists(customersModel.CustomerID))
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
            return View(customersModel);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersModel = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customersModel == null)
            {
                return NotFound();
            }

            return View(customersModel);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var customersModel = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customersModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersModelExists(string id)
        {
            return _context.Customers.Any(e => e.CustomerID == id);
        }
    }
}
