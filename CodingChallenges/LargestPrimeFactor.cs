/****
**  The prime factors of 13195 are 5, 7, 13 and 29.
**
**  What is the largest prime factor of the number 600851475143 ?
****/

using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CodingChallenges
{
    using System;

    public static class LargestPrimeFactor
    {
        public static int GetLargestPrimeFactor()
        {
            long number = 600851475143;
            int maxPrime = -1;
            
            for (int i = 3; i <= Math.Sqrt(number); i += 2) { 
                while (number % i == 0) { 
                    maxPrime = i; 
                    number /= i;
                }
            } 
   
            if (number > 2) 
                maxPrime = (int) number; 
  
            return maxPrime; 
        }
    }
}
