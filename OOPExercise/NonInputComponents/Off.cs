using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public sealed class Off : NonInputComponent
	{

		public override bool TheOutput
		{
			get
			{
				return false;
			}
		}
	}
}

