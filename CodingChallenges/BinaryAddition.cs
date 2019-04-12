/****
**  Implement a function that adds two numbers together and returns their sum in binary.
**  The conversion can be done before, or after the addition.
**
**  Note: The binary number returned should be a string.
****/

namespace CodingChallenges
{
    using System;

    public static class BinaryAddition
    {
        public static string ComputeBinarySum(int a, int b)
        {
            var sum = a + b;
            return Convert.ToString(sum, 2);
        }
    }
}
