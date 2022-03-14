using PmwebProjeto.Models;
using System.Collections.Generic;

namespace PmwebProjeto.Repositories
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> Hoteis { get; }
    }
}
