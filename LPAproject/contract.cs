using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    class contract  // Denk na over implementatie
    {
        public huurder huurder;
        public List<Boot> boten;
        public List<bijkomendArtikel> bijkomendeArtikelen;

        public contract(huurder Huurder)
        {
            this.huurder = Huurder;
        }

    }
}
