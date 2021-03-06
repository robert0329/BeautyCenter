using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeautyCenterCore.Models;
using BeautyCenterCore.BLL;
using Microsoft.AspNetCore.Authorization;

namespace BeautyCenterCore.Controllers
{
    [Authorize(ActiveAuthenticationSchemes = "CookiePolicy")]
    public class FacturasController : Controller
    {
        private readonly BeautyCoreDb _context;
        BeautyCoreDb db = new BeautyCoreDb();

        public FacturasController(BeautyCoreDb context)
        {
            _context = context;
        }

        [HttpPost]
        public JsonResult Save(Facturas nueva)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                nueva.Fecha = DateTime.Now;
                if (FacturasBLL.Guardar(nueva))
                {
                    id = nueva.FacturaId;
                }
            }
            else
            {
                id = +1;
            }
            return Json(id);
        }

        // GET: Facturas
        public IActionResult Index()
        {
            List<Facturas> f = BLL.FacturasBLL.GetLista();
            return View(f);
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await _context.Facturas
                .SingleOrDefaultAsync(m => m.FacturaId == id);
            if (facturas == null)
            {
                return NotFound();
            }

            return View(facturas);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FacturaId,ClienteId,Fecha,Total")] Facturas facturas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facturas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(facturas);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await _context.Facturas.SingleOrDefaultAsync(m => m.FacturaId == id);
            if (facturas == null)
            {
                return NotFound();
            }
            return View(facturas);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FacturaId,ClienteId,Fecha,Total")] Facturas facturas)
        {
            if (id != facturas.FacturaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facturas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturasExists(facturas.FacturaId))
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
            return View(facturas);
        }

        // GET: Facturas/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Facturas nuevo = BLL.FacturasBLL.Buscar(id);
            if (nuevo == null)
            {
                return NotFound();
            }

            return View(nuevo);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Facturas nuevo = BLL.FacturasBLL.Buscar(id);
            BLL.FacturasBLL.Eliminar(nuevo);
            return RedirectToAction("Index");
        }

        private bool FacturasExists(int id)
        {
            return _context.Facturas.Any(e => e.FacturaId == id);
        }
    }
}
