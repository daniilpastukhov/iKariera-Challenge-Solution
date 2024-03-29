﻿/****
**  The function IsPrime() takes one integer argument and
**  returns true or false depending on if the integer is a prime.
**  Per Wikipedia, a prime number (or a prime) is a natural number greater
**  than 1 that has no positive divisors other than 1 and itself.
**
**  IsPrime(5) => true
**
**  Notes:
**      - you can assume you will be given an integer input.
**      - you can not assume that the integer will be only positive.
**      - you may be given negative numbers as well (or 0).
****/

namespace CodingChallenges
{
    using System;

    public static class Prime
    {
        public static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}