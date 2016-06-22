using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    class bijkomendArtikel : prijs
    {
        public string naam { get; set; }
        public int prijs { get; set; }

        public bijkomendArtikel(string naam, int prijs)
        {
            this.naam = naam;
            this.prijs = prijs;
        }
    }
}
