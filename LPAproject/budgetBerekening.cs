using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    public static class budgetBerekening
    {
        public static int aantalMeren;


        // De waardes voor het berekenen van het aantal meren komen uit het sloepkeForm. 
        public static int berekenMeren(double budget, int bootPrijs, int aantalBijkomendeArtikelen, bool noordZee, bool ijsselMeer)
        {
            // Het budget verminderen met de kosten van de gekozen boten en extra artikelen
            budget -= bootPrijs;
            budget -= aantalBijkomendeArtikelen * 1.25;
            if (noordZee == true)
            {
                budget -= 2;
            }
            if (ijsselMeer == true)
            {
                budget -= 2;
            }

            while (budget >= 1)
            {
                if (aantalMeren >= 5)   // Nadat er vijf meren zijn toegevoegd wordt er extra sluisgeld betaald
                {
                    budget -= 1.5;
                    aantalMeren += 1;
                }
                else
                {
                    budget -= 1;
                    aantalMeren += 1;
                }         
            }
            return aantalMeren;
        }
    }
}
