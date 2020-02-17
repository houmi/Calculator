using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Arithmetic
    {
       
        private Stack<double> _numberStack;
        private Stack<char> _operatorStack;
        private bool decimalPoint;
        

        private enum State {
            ADSM,
            Execute,
            Digit
        };

        private State calcState;
        private double mult;


        public double topNumber
        {
            get
            {
                return _numberStack.Peek();
            }
            set
            {
                if (_numberStack.Count > 0)
                {
                    _numberStack.Pop();
                }
                _numberStack.Push(value);
            }
        }

        public Arithmetic()
        {
            _numberStack = new Stack<double>();
            _operatorStack = new Stack<char>();
            topNumber = 0;
            decimalPoint = false;
            calcState = State.Digit;
            mult = .1;
        }

        

        public double increase(double num)
        {
            if (calcState == State.Execute)
            {
                Clear();
            }

            if (calcState == State.ADSM)
            {
                _numberStack.Push(0);
                mult = .1;
                decimalPoint = false;
            }

            calcState = State.Digit;

            // don't go past 9 digits
            if (topNumber.ToString().Length == 9)
            {
                return topNumber;
            }

            if (decimalPoint)
            {
                topNumber = (num * mult) + topNumber;
                mult *= .1;
            }
            else
            {
                topNumber = topNumber * 10 + num;
            }

            return topNumber;
 
        }

        public void Operation(char op, out bool display) {

            display = false;

            if (op == '=')
            {
                if (_operatorStack.Count == 0)
                {
                    return;
                }

                execute();
                calcState = State.Execute;
                display = true;
                return;

            }

            // if one operation right after another, discard previous
            if (calcState == State.ADSM) 
            {
                _operatorStack.Pop();
                _operatorStack.Push(op);
                return;
            }

            if (_numberStack.Count == 2 && _operatorStack.Count == 1)
            {
                execute();
                _operatorStack.Push(op);
                calcState = State.ADSM;
                display = true;
                return;
            }

            _operatorStack.Push(op);
           // _numberStack.Push(0);
            calcState = State.ADSM;
            return;
        }

        public void execute()
        {
            bool singleNumber = false;
            double number1, number2;
            if (_numberStack.Count == 1)
            {
                number1 = number2 = topNumber;
                singleNumber = true;
            } else if (_numberStack.Count == 2)
            {
                number2 = _numberStack.Pop();
                number1 = _numberStack.Pop();
            } else
            {
                return;
            }

            char op;

            if (singleNumber)
            {
                op = _operatorStack.Peek();
            } else
            {
                op = _operatorStack.Pop();
            }
            if (op == '+')
            {
                topNumber = number1 + number2;
            } else if (op == '-')
            {
                topNumber = number1 - number2;
            } else if (op == '/')
            {
                topNumber = number1 / number2;
            } else if (op == '*')
            {
                topNumber = number1 * number2;
            }

            return;
        }

        public void negate()
        {
            if (topNumber != 0)
            {
                topNumber *= -1;
            }
        }

        public void Clear()
        {
            _numberStack.Clear();
            _operatorStack.Clear();
            calcState = State.Digit;
            topNumber = 0;
            decimalPoint = false;
            mult = .1;
        }

        public void decimalPointSet()
        {
            decimalPoint = true;
        }
    }
}
;