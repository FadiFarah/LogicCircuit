using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface ICircuit
    {
        int TheCarry { get; }
        int TheSum { get; }
    }
}
