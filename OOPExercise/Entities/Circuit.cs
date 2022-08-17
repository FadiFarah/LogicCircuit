using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Circuit : ICircuit
    {
		/// The calculated output. Avoid circuit loops.
		public abstract int TheCarry
		{
			get;
		}

		/// The calculated output. Avoid circuit loops.
		public abstract int TheSum
		{
			get;
		}
	}
}
