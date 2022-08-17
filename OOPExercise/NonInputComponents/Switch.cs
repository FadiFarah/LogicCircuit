using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public sealed class Switch : NonInputComponent
	{
		/// <summary>
		/// The current switch state
		/// </summary>
		public bool State
		{
			get
			{
				return _state;
			}
			set
			{
				_state = value;
			}
		}
		/// <summary>
		/// Change the switch state to the opposite value
		/// </summary>
		public void Toggle()
		{
			_state = !_state;
		}

		public override bool TheOutput
		{
			get
			{
				return _state;
			}
		}
		private bool _state;
	}
}

