using PmwebProjeto.Context;
using PmwebProjeto.Models;
using System.Collections.Generic;

namespace PmwebProjeto.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly AppDbContext _context;

        public HotelRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Hotel> Hoteis => _context.Hoteis;
    }
}
