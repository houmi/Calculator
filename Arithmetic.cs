using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Arithmetic
    {
       
        private long number;
        private Stack<long> _numberStack;
        private Stack<char> _operatorStack;
  
        public Arithmetic()
        {
            number = 0;
            _numberStack = new Stack<long>();
            _operatorStack = new Stack<char>();
        }

        public long increase(long num)
        {
            if (number.ToString().Length == 9)
            {
                return number;
            }

            return number = number * 10 + num;
 
        }

        public void Operation(char op) {
            
            if (_numberStack.Count == 1 && _operatorStack.Count == 1) 
            {
                _operatorStack.Pop();
                _operatorStack.Push(op);
                return;
            }

            if (_numberStack.Count == 2 && _operatorStack.Count == 2)
            {
                execute();
                _operatorStack.Push(op);
                return;
            }

            _numberStack.Push(number);
            number = 0;
            _operatorStack.Push(op);

            return;
        }

        public long execute()
        {
            long number1, number2;
            if (_numberStack.Count == 1)
            {
                number1 = number2 = _numberStack.Pop();
            } else if (_numberStack.Count == 2)
            {
                number2 = _numberStack.Pop();
                number1 = _numberStack.Pop();
            } else
            {
                return 0;
            }

            char op = _operatorStack.Pop();
            if (op == '+')
            {
                number = number1 + number2;
            } else if (op == '-')
            {
                number = number1 - number2;
            } else if (op == '/')
            {
                number = number1 / number2;
            } else if (op == '*')
            {
                number = number1 * number2;
            }

            _numberStack.Clear();
            _operatorStack.Clear();
            
            return number;
        }

        public void Clear()
        {
            number = 0;
            _numberStack.Clear();
            _operatorStack.Clear();
        }
    }
}
;