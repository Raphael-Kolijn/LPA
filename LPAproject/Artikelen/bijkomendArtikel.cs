using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    public class bijkomendArtikel : prijs
    {
        public string naam { get; set; }
        public double prijs { get; set; }

        public bijkomendArtikel(string naam, double prijs)
        {
            this.naam = naam;
            this.prijs = prijs;
        }
    }
}
