using PmwebProjeto.Models;
using System.Collections.Generic;

namespace PmwebProjeto.Repositories
{
    public interface IQuartoRepository
    {
        IEnumerable<Quarto> Quartos { get; }
    }
}
