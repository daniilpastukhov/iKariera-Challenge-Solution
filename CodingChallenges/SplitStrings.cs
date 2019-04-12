/****
**  Complete the solution so that it splits the string into pairs of two characters.
**
**  If the string contains an odd number of characters then it should replace the missing
**  second character of the final pair with an underscore ('_').
**
**  Examples:
**      - SplitIt("abc");    ->   should return ["ab", "c_"]
**      - SplitIt("abcdef"); ->   should return ["ab", "cd", "ef"]
****/

using System.Security.Cryptography.X509Certificates;

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class SplitStrings
    {
        public static string[] SplitIt(string str)
        {
            if (str.Length % 2 == 1) str += '_';
            string[] result = new string[str.Length / 2];
            int index = 0;

            for (int i = 0; i < str.Length; i += 2)
            {
                result[index++] = str.Substring(i,  2);
            }
            
            return result;
        }
    }
}
