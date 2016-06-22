using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPAproject
{
    class zeilboot : Boot
    {
        private bool motor = false;
        public int prijs = 10;
        public string type;

        public zeilboot(string Type)
        {
            this.type = Type;
        }
    }
}
