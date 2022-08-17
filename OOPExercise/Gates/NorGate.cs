using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class NorGate
    {
        public bool CheckNor(bool state1, bool state2)
        {
            return (state1 || state2) ? false : true;
        }
    }
}
