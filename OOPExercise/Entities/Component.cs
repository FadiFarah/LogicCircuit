using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	/// The base class for all components
	public abstract class Component : IComponent
    {
		protected Component(int numberofInput)
		{
			_numberOfInputs = numberofInput;
		}

		/// The number of inputs that the component has. 
		public int NumberOfInputs
		{
			get
			{
				return _numberOfInputs;
			}
		}

		/// The calculated output. Avoid circuit loops.
		public abstract bool TheOutput
		{
			get;
		}

		public override string ToString()
		{
			return TheOutput ? "1" : "0";
		}
		private readonly int _numberOfInputs;
	}
}
