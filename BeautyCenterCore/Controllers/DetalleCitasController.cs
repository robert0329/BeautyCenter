using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeautyCenterCore.Models;
using Microsoft.AspNetCore.Authorization;

namespace BeautyCenterCore.Controllers
{
    [Authorize(ActiveAuthenticationSchemes = "CookiePolicy")]
    public class DetalleCitasController : Controller
    {
        private readonly BeautyCoreDb _context;

        public DetalleCitasController(BeautyCoreDb context)
        {
            _context = context;
        }
        [HttpPost]
        public JsonResult Save([FromBody]List<DetalleCitas> detalles)
        {
            bool resultado = BLL.DetalleCitasBLL.Insertar(detalles);

            return Json(resultado);
        }
        // GET: DetalleCitas
        public async Task<IActionResult> Index()
        {
            return View(await _context.DetalleCitas.ToListAsync());
        }

        // GET: DetalleCitas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCitas = await _context.DetalleCitas
                .SingleOrDefaultAsync(m => m.Id == id);
            if (detalleCitas == null)
            {
                return NotFound();
            }

            return View(detalleCitas);
        }

        // GET: DetalleCitas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DetalleCitas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CitaId,ClienteId,Servicio")] DetalleCitas detalleCitas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleCitas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(detalleCitas);
        }

        // GET: DetalleCitas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCitas = await _context.DetalleCitas.SingleOrDefaultAsync(m => m.Id == id);
            if (detalleCitas == null)
            {
                return NotFound();
            }
            return View(detalleCitas);
        }

        // POST: DetalleCitas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CitaId,ClienteId,Servicio")] DetalleCitas detalleCitas)
        {
            if (id != detalleCitas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleCitas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleCitasExists(detalleCitas.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(detalleCitas);
        }

        // GET: DetalleCitas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCitas = await _context.DetalleCitas
                .SingleOrDefaultAsync(m => m.Id == id);
            if (detalleCitas == null)
            {
                return NotFound();
            }

            return View(detalleCitas);
        }

        // POST: DetalleCitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleCitas = await _context.DetalleCitas.SingleOrDefaultAsync(m => m.Id == id);
            _context.DetalleCitas.Remove(detalleCitas);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DetalleCitasExists(int id)
        {
            return _context.DetalleCitas.Any(e => e.Id == id);
        }
    }
}
