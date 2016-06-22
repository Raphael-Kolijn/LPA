using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    public class motorboot : Boot
    {
        public static List<motorboot> alleMotorBoten = new List<motorboot>();

        public string naam;
        private readonly bool motor = true;
        public readonly double prijs = 15;
        public int tankinhoud {get; set;}

        public motorboot(int TankInhoud, string Naam)
        {
            this.tankinhoud = TankInhoud;
            this.naam = Naam;
        }
    }
}
