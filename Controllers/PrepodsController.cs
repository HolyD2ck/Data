using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Data.Controllers
{
    public class PrepodsController : Controller
    {
        private readonly DataContext _context;

        public PrepodsController(DataContext context)
        {
            _context = context;
            _context.EnsureData2();
        }

        // GET: Prepods
        public async Task<IActionResult> Index()
        {
              return _context.Prepod != null ? 
                          View(await _context.Prepod.ToListAsync()) :
                          Problem("Entity set 'DataContext.Prepod'  is null.");
        }

        // GET: Prepods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prepod == null)
            {
                return NotFound();
            }

            var prepod = await _context.Prepod
                .FirstOrDefaultAsync(m => m.id == id);
            if (prepod == null)
            {
                return NotFound();
            }

            return View(prepod);
        }

        // GET: Prepods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prepods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Фамилия,Имя,Отчество,Куратор_Группы,Профессия,День_Рождения,Номер_Кабинета,Зарплата,Стаж")] Prepod prepod)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prepod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prepod);
        }

        // GET: Prepods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prepod == null)
            {
                return NotFound();
            }

            var prepod = await _context.Prepod.FindAsync(id);
            if (prepod == null)
            {
                return NotFound();
            }
            return View(prepod);
        }

        // POST: Prepods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Фамилия,Имя,Отчество,Куратор_Группы,Профессия,День_Рождения,Номер_Кабинета,Зарплата,Стаж")] Prepod prepod)
        {
            if (id != prepod.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prepod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrepodExists(prepod.id))
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
            return View(prepod);
        }

        // GET: Prepods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prepod == null)
            {
                return NotFound();
            }

            var prepod = await _context.Prepod
                .FirstOrDefaultAsync(m => m.id == id);
            if (prepod == null)
            {
                return NotFound();
            }

            return View(prepod);
        }

        // POST: Prepods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prepod == null)
            {
                return Problem("Entity set 'DataContext.Prepod'  is null.");
            }
            var prepod = await _context.Prepod.FindAsync(id);
            if (prepod != null)
            {
                _context.Prepod.Remove(prepod);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrepodExists(int id)
        {
          return (_context.Prepod?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
