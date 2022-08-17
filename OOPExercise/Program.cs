using Logic;
using System;

namespace TestLogic
{
    class LogicCircute
    {
        static void Main(string[] args)
        {
			var s1 = new Switch { State = false };
			var s2 = new Switch { State = false };
			var cIn = new Switch { State = false };

			var fullAdder = new FullAdder();

			fullAdder.SetInputComponentAt(0, s1);
			fullAdder.SetInputComponentAt(1, s2);
			fullAdder.SetInputComponentAt(2, cIn);

			//0 + 0 + 0 = 0 (0)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			cIn.Toggle();
			// 0 + 0 + 1 = 1 (0)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			cIn.Toggle();
			s1.Toggle();
			//0 + 1 + 0 = 1 (0)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			cIn.Toggle();
			//0 + 1 + 1 = 0 (1)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			s1.Toggle();
			s2.Toggle();
			cIn.Toggle();
			//1 + 0 + 0 = 1 (0)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			cIn.Toggle();
			// 1 + 0 + 1 = 0 (1)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			s1.Toggle();
			cIn.Toggle();
			//1 + 1 + 0 = 0 (1)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

			cIn.Toggle();
			//1 + 1 + 1 = 1 (1)
			Console.WriteLine("{0} + {1} + {2} = {3} ({4})", s2, s1, cIn, fullAdder, fullAdder.TheCarry);

		}
	}
}
