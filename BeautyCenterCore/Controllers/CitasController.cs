using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeautyCenterCore.Models;
using BeautyCenterCore.BLL;

namespace BeautyCenterCore.Controllers
{
    public class CitasController : Controller
    {
        private readonly BeautyCoreDb _context;

        [HttpGet]
        public JsonResult Lista(int id)
        {
            var listado = BLL.DetalleCitasBLL.GetListaId(id);

            return Json(listado);
        }
        [HttpGet]
        public JsonResult Listado(int id)
        {
            var listado = BLL.CitasBLL.GetListaId(id);

            return Json(listado);
        }
        public CitasController(BeautyCoreDb context)
        {
            _context = context;
        }
        [HttpPost]
        public JsonResult Save(Citas nueva)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                nueva.Fecha = DateTime.Now;
                if (CitasBLL.Insertar(nueva))
                {
                    id = nueva.CitaId;
                }
            }
            else
            {
                id = +1;
            }
            return Json(id);
        }
        // GET: Citas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Citas.ToListAsync());
        }

        // GET: Citas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var citas = await _context.Citas
                .SingleOrDefaultAsync(m => m.CitaId == id);
            if (citas == null)
            {
                return NotFound();
            }

            return View(citas);
        }

        // GET: Citas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Citas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CitaId,ClienteId,ServicioId,CantPersonas,Fecha")] Citas citas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(citas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(citas);
        }

        // GET: Citas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var citas = await _context.Citas.SingleOrDefaultAsync(m => m.CitaId == id);
            if (citas == null)
            {
                return NotFound();
            }
            return View(citas);
        }

        // POST: Citas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CitaId,ClienteId,ServicioId,CantPersonas,Fecha")] Citas citas)
        {
            if (id != citas.CitaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(citas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitasExists(citas.CitaId))
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
            return View(citas);
        }

        // GET: Citas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var citas = await _context.Citas
                .SingleOrDefaultAsync(m => m.CitaId == id);
            if (citas == null)
            {
                return NotFound();
            }

            return View(citas);
        }

        // POST: Citas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var citas = await _context.Citas.SingleOrDefaultAsync(m => m.CitaId == id);
            _context.Citas.Remove(citas);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CitasExists(int id)
        {
            return _context.Citas.Any(e => e.CitaId == id);
        }
    }
}
