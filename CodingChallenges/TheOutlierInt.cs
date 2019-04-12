﻿/****
**  You are given an array (which will have a length of at least 3, but could be very large)
**  containing integers. The array is either entirely comprised of odd integers or entirely
**  comprised of even integers except for a single integer N. Write a method that takes the
**  array as an argument and returns this "outlier" N.
**
**  Examples:
**  [2, 4, 0, 100, 4, 11, 2602, 36]
**  Should return: 11 (the only odd number)
**
**  [160, 3, 1719, 19, 11, 13, -21]
**  Should return: 160 (the only even number)
****/

namespace CodingChallenges
{
    using System;
    using System.Linq;

    public static class TheOutlierInt
    {
        public static int Find(int[] sequence)
        {
            bool isSeqOdd = (sequence[0] % 2 == 1 && sequence[1] % 2 == 1)
                            || (sequence[1] % 2 == 1 && sequence[2] % 2 == 1)
                            || (sequence[0] % 2 == 1 && sequence[2] % 2 == 1);

            foreach (var i in sequence)
            {
                if (isSeqOdd && i % 2 == 0) return i;
                if (!isSeqOdd && i % 2 == 1) return i;
            }
            
            return 0;
        }
    }
}
