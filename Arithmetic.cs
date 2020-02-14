using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Arithmetic
    {
       
        private Stack<long> _numberStack;
        private Stack<char> _operatorStack;
  
        public Arithmetic()
        {
            _numberStack = new Stack<long>();
            topNumber = 0;
            _operatorStack = new Stack<char>();
        }

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

        public long increase(long num)
        {
            if (topNumber.ToString().Length == 9)
            {
                return topNumber;
            }
   
            return topNumber = topNumber * 10 + num;
 
        }

        public void Operation(char op) {
            
            // if one operation right after another, discard previous
            if (_numberStack.Count == 1 && _operatorStack.Count == 1 && op != '=') 
            {
                _operatorStack.Pop();
                _operatorStack.Push(op);
                return;
            }

            if (op == '=')
            {
                if (_numberStack.Count <= 1 && _operatorStack.Count == 0)
                {
                    return;
                }

                execute();
                return;

            }

            if (_numberStack.Count == 2 && _operatorStack.Count == 1)
            {
                execute();
                _operatorStack.Push(op);
                return;
            }

            _operatorStack.Push(op);
            _numberStack.Push(0);
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

        public void Clear()
        {
            _numberStack.Clear();
            _operatorStack.Clear();
            topNumber = 0;
        }
    }
}
;