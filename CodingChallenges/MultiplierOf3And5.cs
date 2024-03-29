﻿/****
**  If we list all the natural numbers below 10 that are multiples of 3 or 5,
**  we get 3, 5, 6 and 9. The sum of these multiples is 23.
**
**  Find the sum of all the multiples of 3 or 5 below 1000.
****/

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class MultiplierOf3And5
    {
        public static int ComputeSum()
        {
            // TODO Add implementation
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            
            return sum;
        }
    }
}
