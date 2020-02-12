using System.Collections.Generic;

namespace Calculator
{
    public class Arithmetic
    {
       
        private long number1;
        private Stack<int> _numberStack;
        private Stack<char> _operatorStack;

        public Arithmetic()
        {
            number1 = 0;
        }

        public long increase(long num)
        {
            number1 = number1 * 10 + num;
            return number1;
        }


    }
}
