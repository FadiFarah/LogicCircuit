using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class NonInputComponent
    {
		public virtual bool TheOutput { get; set; }

		public override string ToString()
		{
			return TheOutput ? "1" : "0";
		}
	}
}
