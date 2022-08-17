using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	/// A singleton class that returns true
	public sealed class On : NonInputComponent
	{
		public override bool TheOutput
		{
			get
			{
				return true;
			}
		}

	}
}

