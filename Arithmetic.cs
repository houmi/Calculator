using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Arithmetic
    {
       
        private long number1;
        private Stack<long> _numberStack;
        private Stack<char> _operatorStack;
        public enum ArithmeticOperation {
            addition,
            subtraction,
            multiplication,
            division,
            inverse,
            square,
            squareroot
        };

        public Arithmetic()
        {
            number1 = 0;
            _numberStack = new Stack<long>();
            _operatorStack = new Stack<char>();
        }

        public long increase(long num)
        {
            long newNumber = (number1 * 10) + num;
            long prevNumber = (newNumber - num) / 10;
            //System.Diagnostics.Debug.WriteLine(num.ToString() + " " + newNumber.ToString() + " " + prevNumber.ToString());
            if (prevNumber != number1)
            {
                return number1;
            }

            return number1 = newNumber;
 
        }

        public void Operation(ArithmeticOperation operationMode) {
            char op;

            switch (operationMode)
            {
                case ArithmeticOperation.addition:
                    op = '+';
                    break;
                case ArithmeticOperation.subtraction:
                    op = '-';
                    break;
                case ArithmeticOperation.division:
                    op = '/';
                    break;
                case ArithmeticOperation.multiplication:
                    op = '*';
                    break;
                default:
                    return;
            }

            // in case user has pressed the operation again after a last operation
            // like 12 + * , we pop + and add *
            if (_numberStack.Count == _operatorStack.Count && 
                _operatorStack.Count != 0)
            {
                _operatorStack.Pop();
                _operatorStack.Push(op);
                return;
            }

            _numberStack.Push(number1);
            number1 = 0;
            _operatorStack.Push(op);
            return;
        }
    }
}
;