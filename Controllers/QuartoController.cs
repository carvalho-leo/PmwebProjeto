using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PmwebProjeto.Context;
using PmwebProjeto.Models;

namespace PmwebProjeto.Controllers
{
    public class QuartoController : Controller
    {
        private readonly AppDbContext _context;

        public QuartoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Quarto
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Quartos.Include(q => q.Hotel);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Quarto/Details/*
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quarto = await _context.Quartos
                .Include(q => q.Hotel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quarto == null)
            {
                return NotFound();
            }

            return View(quarto);
        }

        // GET: Quarto/Create
        public IActionResult Create()
        {
            ViewData["HotelId"] = new SelectList(_context.Hoteis, "Id", "Id");
            return View();
        }

        // POST: Quarto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,NumeroOcupantes,NumeroAdultos,NumeroCriancas,Preco,HotelId")] Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quarto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HotelId"] = new SelectList(_context.Hoteis, "Id", "Id", quarto.HotelId);
            return View(quarto);
        }

        // GET: Quarto/Edit/*
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quarto = await _context.Quartos.FindAsync(id);
            if (quarto == null)
            {
                return NotFound();
            }
            ViewData["HotelId"] = new SelectList(_context.Hoteis, "Id", "Id", quarto.HotelId);
            return View(quarto);
        }

        // POST: Quarto/Edit/*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,NumeroOcupantes,NumeroAdultos,NumeroCriancas,Preco,HotelId")] Quarto quarto)
        {
            if (id != quarto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quarto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuartoExists(quarto.Id))
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
            ViewData["HotelId"] = new SelectList(_context.Hoteis, "Id", "Id", quarto.HotelId);
            return View(quarto);
        }

        // GET: Quarto/Delete/*
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quarto = await _context.Quartos
                .Include(q => q.Hotel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quarto == null)
            {
                return NotFound();
            }

            return View(quarto);
        }

        // POST: Quarto/Delete/*
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quarto = await _context.Quartos.FindAsync(id);
            _context.Quartos.Remove(quarto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuartoExists(int id)
        {
            return _context.Quartos.Any(e => e.Id == id);
        }
    }
}
