using System;
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
            long newNumber = (number1 * 10) + num;
            long prevNumber = (newNumber - num) / 10;
            //System.Diagnostics.Debug.WriteLine(num.ToString() + " " + newNumber.ToString() + " " + prevNumber.ToString());
            if (prevNumber != number1)
            {
                return number1;
            }

            return number1 = newNumber;
 
        }


    }
}
;