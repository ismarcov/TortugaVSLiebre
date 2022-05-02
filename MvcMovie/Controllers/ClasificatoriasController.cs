using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using TortugaLiebre.Models;

namespace MvcMovie.Controllers
{
    public class ClasificatoriasController : Controller
    {
        private readonly MvcMovieContext _context;

        public ClasificatoriasController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Clasificatorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clasificatorias.ToListAsync());
        }

        // GET: Clasificatorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificatorias = await _context.Clasificatorias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clasificatorias == null)
            {
                return NotFound();
            }

            return View(clasificatorias);
        }

        // GET: Clasificatorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clasificatorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumCarrera,Id,Ganador,FechaCarrera,Apostadores,Ganancias")] Clasificatorias clasificatorias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificatorias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificatorias);
        }

        public async Task<IActionResult> agregar(Clasificatorias clasificatoria)
        {
            if(ModelState.IsValid)
            {
                _context.Add(clasificatoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificatoria);
        }

        // GET: Clasificatorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificatorias = await _context.Clasificatorias.FindAsync(id);
            if (clasificatorias == null)
            {
                return NotFound();
            }
            return View(clasificatorias);
        }

        // POST: Clasificatorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumCarrera,Id,Ganador,FechaCarrera,Apostadores,Ganancias")] Clasificatorias clasificatorias)
        {
            if (id != clasificatorias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificatorias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasificatoriasExists(clasificatorias.Id))
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
            return View(clasificatorias);
        }

        // GET: Clasificatorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificatorias = await _context.Clasificatorias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clasificatorias == null)
            {
                return NotFound();
            }

            return View(clasificatorias);
        }

        // POST: Clasificatorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificatorias = await _context.Clasificatorias.FindAsync(id);
            _context.Clasificatorias.Remove(clasificatorias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasificatoriasExists(int id)
        {
            return _context.Clasificatorias.Any(e => e.Id == id);
        }
    }
}
