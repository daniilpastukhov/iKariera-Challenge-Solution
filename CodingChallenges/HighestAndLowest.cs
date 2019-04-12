/****
**  In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
**
**  Example:
**  numbers = "1 2 3 4 5" -> "5 1"
**  numbers = "1 2 -3 4 5" -> "5 -3"
**  numbers = "1 9 3 4 -5" -> "9 -5"
**
**  Notes:
**      - all numbers are valid Int32, no need to validate them.
**      - there will always be at least one number in the input string.
**      - output string must be two numbers separated by a single space, and highest number is first.
****/


namespace CodingChallenges
{
    using System;
    using System.Linq;

    public static class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string[] split = numbers.Split(" ");
            int[] arr = new int[split.Length];
            int index = 0;
            
            foreach (var i in split) arr[index++] = Int32.Parse(i);

            int min = arr[0], max = arr[0];

            foreach (var i in arr)
            {
                if (i < min) min = i;
                else if (i > max) max = i;
            }
            
            return max.ToString() + " " + min.ToString();
        }
    }
}