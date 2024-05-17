using AgroPlus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgroPlus.Controllers
{
    public class InfoRegiaosController : Controller
    {
        private readonly Contexto _context;

        public InfoRegiaosController(Contexto context)
        {
            _context = context;
        }

        // GET: InfoRegiaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.InfoRegiao.ToListAsync());
        }

        // GET: InfoRegiaos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoRegiao = await _context.InfoRegiao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoRegiao == null)
            {
                return NotFound();
            }

            return View(infoRegiao);
        }

        // GET: InfoRegiaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InfoRegiaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Temperatura,Umidade,Precipitacao,DataInfo")] InfoRegiao infoRegiao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infoRegiao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infoRegiao);
        }

        // GET: InfoRegiaos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoRegiao = await _context.InfoRegiao.FindAsync(id);
            if (infoRegiao == null)
            {
                return NotFound();
            }
            return View(infoRegiao);
        }

        // POST: InfoRegiaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Temperatura,Umidade,Precipitacao,DataInfo")] InfoRegiao infoRegiao)
        {
            if (id != infoRegiao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoRegiao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoRegiaoExists(infoRegiao.Id))
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
            return View(infoRegiao);
        }

        // GET: InfoRegiaos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoRegiao = await _context.InfoRegiao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoRegiao == null)
            {
                return NotFound();
            }

            return View(infoRegiao);
        }

        // POST: InfoRegiaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var infoRegiao = await _context.InfoRegiao.FindAsync(id);
            if (infoRegiao != null)
            {
                _context.InfoRegiao.Remove(infoRegiao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoRegiaoExists(long id)
        {
            return _context.InfoRegiao.Any(e => e.Id == id);
        }
    }
}
