using Microsoft.EntityFrameworkCore;
using PmwebProjeto.Context;
using PmwebProjeto.Models;
using System.Collections.Generic;

namespace PmwebProjeto.Repositories
{
    public class QuartoRepository : IQuartoRepository
    {
        private readonly AppDbContext _context;

        public QuartoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Quarto> Quartos => _context.Quartos.Include(c => c.Hotel);
    }
}
