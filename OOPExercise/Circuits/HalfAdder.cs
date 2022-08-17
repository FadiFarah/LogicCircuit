using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public sealed class HalfAdder : Circuit
    {
        private readonly AndGate _andGate;
        private readonly XorGate _xorGate;
        //Sum is 1 when odd number of Inputs is 1
        //Co is 1 when atleast two Inputs are 1

        private readonly List<NonInputComponent> _inputComponents;
        public HalfAdder()
        {
            _inputComponents = new List<NonInputComponent>(new NonInputComponent[2]);
            _andGate = new AndGate();
            _xorGate = new XorGate();
        }

        public override int TheCarry
        {
            get
            {
                return _andGate.CheckAnd(_inputComponents[0].TheOutput, _inputComponents[1].TheOutput) ? 1 : 0;
            }
        }

        public override int TheSum
        {
            get
            {
                return _xorGate.CheckXor(_inputComponents[0].TheOutput, _inputComponents[1].TheOutput) ? 1 : 0;
            }
        }


        public void SetInputComponentAt(int num, NonInputComponent inputComponent)
        {
            try
            {
                _inputComponents[num] = inputComponent;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            return TheSum.ToString();
        }
    }
}
