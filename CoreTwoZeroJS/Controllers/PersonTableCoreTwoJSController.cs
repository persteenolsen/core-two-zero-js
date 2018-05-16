using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreTwoZeroJS.Models;

namespace CoreTwoZeroJS.Controllers
{
    public class PersonTableCoreTwoJSController : Controller
    {
        
        private readonly MydbContext _context;

       
        public PersonTableCoreTwoJSController(MydbContext context)
        {
            _context = context;
        }

        // GET: PersonTableCoreTwoJS
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonTableCoreTwoJS.ToListAsync());
        }

        // GET: PersonTableCoreTwoJS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTableCoreTwoJS = await _context.PersonTableCoreTwoJS
                .SingleOrDefaultAsync(m => m.Id == id);
            if (personTableCoreTwoJS == null)
            {
                return NotFound();
            }

            return View(personTableCoreTwoJS);
        }

        // GET: PersonTableCoreTwoJS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonTableCoreTwoJS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Phone,Email,Age,Editable")] PersonTableCoreTwoJS personTableCoreTwoJS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personTableCoreTwoJS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personTableCoreTwoJS);
        }

        // GET: PersonTableCoreTwoJS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTableCoreTwoJS = await _context.PersonTableCoreTwoJS.SingleOrDefaultAsync(m => m.Id == id);
            if (personTableCoreTwoJS == null)
            {
                return NotFound();
            }
            return View(personTableCoreTwoJS);
        }

        // POST: PersonTableCoreTwoJS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Phone,Email,Age,Editable")] PersonTableCoreTwoJS personTableCoreTwoJS)
        {
            if (id != personTableCoreTwoJS.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personTableCoreTwoJS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonTableCoreTwoJSExists(personTableCoreTwoJS.Id))
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
            return View(personTableCoreTwoJS);
        }

        // GET: PersonTableCoreTwoJS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personTableCoreTwoJS = await _context.PersonTableCoreTwoJS
                .SingleOrDefaultAsync(m => m.Id == id);
            if (personTableCoreTwoJS == null)
            {
                return NotFound();
            }

            return View(personTableCoreTwoJS);
        }

        // POST: PersonTableCoreTwoJS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personTableCoreTwoJS = await _context.PersonTableCoreTwoJS.SingleOrDefaultAsync(m => m.Id == id);
            _context.PersonTableCoreTwoJS.Remove(personTableCoreTwoJS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonTableCoreTwoJSExists(int id)
        {
            return _context.PersonTableCoreTwoJS.Any(e => e.Id == id);
        }
    }
}
