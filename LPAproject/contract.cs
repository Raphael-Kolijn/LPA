using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    public class contract  // Denk na over implementatie
    {
        public huurder huurder;
        public List<Boot> boten;
        public List<bijkomendArtikel> bijkomendeArtikelen;
        public DateTime datumVan;
        public DateTime datumTot;

        public contract(huurder Huurder, List<Boot> Boten, List<bijkomendArtikel> BijkomendeArtikelen, DateTime DatumVan, DateTime DatumTot)
        {
            this.huurder = Huurder;
            this.boten = Boten;
            this.bijkomendeArtikelen = BijkomendeArtikelen;
            this.datumVan = DatumVan;
            this.datumTot = DatumTot;
        }
    }
}
