using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface IComponent
    {
        int NumberOfInputs { get; }
        bool TheOutput { get; }
    }
}
