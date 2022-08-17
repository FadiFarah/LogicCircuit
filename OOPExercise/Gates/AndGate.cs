using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class AndGate
    {
        public bool CheckAnd(bool state1, bool state2)
        {
            return (state1 && state2) ? true : false;
        }
    }
}
