using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class NandGate
    {
        public bool CheckNand(bool state1, bool state2)
        {
            return (state1 && state2) ? false : true;
        }
    }
}
