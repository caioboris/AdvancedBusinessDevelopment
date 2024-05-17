using AgroPlus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgroPlus.Controllers
{
    public class HistoricoVendasController : Controller
    {
        private readonly Contexto _context;

        public HistoricoVendasController(Contexto context)
        {
            _context = context;
        }

        // GET: HistoricoVendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricoVenda.ToListAsync());
        }

        // GET: HistoricoVendas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoVenda = await _context.HistoricoVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoVenda == null)
            {
                return NotFound();
            }

            return View(historicoVenda);
        }

        // GET: HistoricoVendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Quantidade,ValorTotal")] HistoricoVenda historicoVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historicoVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoVenda);
        }

        // GET: HistoricoVendas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoVenda = await _context.HistoricoVenda.FindAsync(id);
            if (historicoVenda == null)
            {
                return NotFound();
            }
            return View(historicoVenda);
        }

        // POST: HistoricoVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Data,Quantidade,ValorTotal")] HistoricoVenda historicoVenda)
        {
            if (id != historicoVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoVendaExists(historicoVenda.Id))
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
            return View(historicoVenda);
        }

        // GET: HistoricoVendas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoVenda = await _context.HistoricoVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoVenda == null)
            {
                return NotFound();
            }

            return View(historicoVenda);
        }

        // POST: HistoricoVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var historicoVenda = await _context.HistoricoVenda.FindAsync(id);
            if (historicoVenda != null)
            {
                _context.HistoricoVenda.Remove(historicoVenda);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoVendaExists(long id)
        {
            return _context.HistoricoVenda.Any(e => e.Id == id);
        }
    }
}
