/****
**  Write a function, persistence, that takes in a positive parameter 'num' and
**  returns its multiplicative persistence, which is the number of times
**  you must multiply the digits in num until you reach a single digit.
**
**  For example:
**      ComputePersistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4 = 4
**      and 4 has only one digit
**
**      ComputePersistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, 1*2 = 2
**
**      ComputePersistence(4) == 0 // because 4 is already a one-digit number
****/

using System.Linq;

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public static class PersistenceOfNumbers
    {
        public static int Counter = 0;
        public static int ComputePersistence(long num)
        {
            if (num <= 9)
            {
                int tmp = Counter;
                Counter = 0;
                return tmp;
            }
            
            long copiedNumber = num, newNum = 1;
            var list = new Stack<long>(32);
            do
            {
                list.Push(copiedNumber % 10);
                copiedNumber /= 10;
            } while (copiedNumber != 0);

            long[] arr = list.ToArray();

            foreach (var i in arr) newNum *= i;
            Counter++;
            return ComputePersistence(newNum);
        }
    }
}
