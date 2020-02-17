using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Arithmetic
    {
       
        private Stack<long> _numberStack;
        private Stack<char> _operatorStack;
        bool executed;
        bool isLastOperationASDM;

        public long topNumber
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
            _numberStack = new Stack<long>();
            topNumber = 0;
            executed = false;
            isLastOperationASDM = false;
            _operatorStack = new Stack<char>();
        }

        

        public long increase(long num)
        {
            if (executed)
            {
                Clear();
            }

            if (isLastOperationASDM)
            {
                isLastOperationASDM = false;
            }

            // don't go past 9 digits
            if (topNumber.ToString().Length == 9)
            {
                return topNumber;
            }
   
            return topNumber = topNumber * 10 + num;
 
        }

        public void Operation(char op, out bool display) {

            display = false;

            // if one operation right after another, discard previous
            if (isLastOperationASDM) 
            {
                _operatorStack.Pop();
                _operatorStack.Push(op);
                return;
            }

            if (op == '=')
            {
                if (_operatorStack.Count == 0)
                {
                    return;
                }

                execute();
                display = true;
                executed = true;
                return;

            }

            if (_numberStack.Count == 2 && _operatorStack.Count == 1)
            {
                execute();
                _operatorStack.Push(op);
                isLastOperationASDM = true;
                display = true;
                executed = true;
                return;
            }

            if (executed)
            {
                executed = false;
            }
            _operatorStack.Push(op);
            _numberStack.Push(0);
            isLastOperationASDM = true;
            return;
        }

        public void execute()
        {
            long number1, number2;
            if (_numberStack.Count == 1)
            {
                number1 = number2 = topNumber;
            } else if (_numberStack.Count == 2)
            {
                number2 = _numberStack.Pop();
                number1 = _numberStack.Pop();
            } else
            {
                return;
            }

            char op = _operatorStack.Pop();
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
            isLastOperationASDM = false;
            executed = false;
            topNumber = 0;
        }
    }
}
;