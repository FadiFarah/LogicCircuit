using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public sealed class FullAdder : Circuit
    {
        private readonly OrGate _orGate;
        private readonly HalfAdder _halfAdderOne;
        private readonly HalfAdder _halfAdderTwo;

        private readonly List<NonInputComponent> _inputComponents;
        public FullAdder()
        {
            _inputComponents = new List<NonInputComponent>( new NonInputComponent[3] ).Select(i => new NonInputComponent()).ToList();
            _halfAdderOne = new HalfAdder();
            _halfAdderTwo = new HalfAdder();
            _orGate = new OrGate();
        }

        public override int TheCarry
        {
            get
            {
                _halfAdderOne.SetInputComponentAt(0, _inputComponents[0]);
                _halfAdderOne.SetInputComponentAt(1, _inputComponents[1]);
                int sumOfHAO = _halfAdderOne.TheSum;
                NonInputComponent n = new NonInputComponent();
                n.TheOutput = sumOfHAO == 1 ? true : false;

                _halfAdderTwo.SetInputComponentAt(0, _inputComponents[2]);
                _halfAdderTwo.SetInputComponentAt(1, n);
                var hAOCarry = _halfAdderOne.TheCarry == 1 ? true : false;
                var hATCarry = _halfAdderTwo.TheCarry == 1 ? true : false;
                return _orGate.CheckOr(hAOCarry, hATCarry) ? 1 : 0;
            }
        }

        public override int TheSum
        {
            get
            {
                _halfAdderOne.SetInputComponentAt(0, _inputComponents[0]);
                _halfAdderOne.SetInputComponentAt(1, _inputComponents[1]);
                int sumOfHAO = _halfAdderOne.TheSum;
                NonInputComponent n = new NonInputComponent();
                n.TheOutput = sumOfHAO == 1 ? true : false;

                _halfAdderTwo.SetInputComponentAt(0, _inputComponents[2]);
                _halfAdderTwo.SetInputComponentAt(1, n);

                return _halfAdderTwo.TheSum;
            }
        }


        public void SetInputComponentAt(int num, NonInputComponent inputComponent)
        {
            try
            {
                _inputComponents[num] = inputComponent;
            }
            catch(ArgumentOutOfRangeException ex)
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
