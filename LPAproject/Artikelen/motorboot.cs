using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    class motorboot : Boot
    {
        private bool motor = true;
        public int prijs = 15;
        public int tankinhoud;

        public motorboot(int TankInhoud)
        {
            this.tankinhoud = TankInhoud;
        }
    }
}
