using PmwebProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmwebProjeto.ViewModel
{
    public class QuartoListViewModel
    {
        public IEnumerable<Quarto> Quartos { get; set; }
        public string HotelAtual { get; set; }
    }
}
