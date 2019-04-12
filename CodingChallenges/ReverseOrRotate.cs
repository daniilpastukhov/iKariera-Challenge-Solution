/****
**  The input is a string str of digits. Cut the string into chunks
**  (a chunk here is a substring of the initial string) of size sz
**  (ignore the last chunk if its size is less than sz).
**
**  If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2,
**  reverse that chunk; otherwise rotate it to the left by one position. Put together these modified
**  hunks and return the result as a string.
**
**  If:
**      - sz is <= 0 or if str is empty return ""
**      - sz is greater (>) than the length of str it is impossible to take a chunk of size sz hence return "".
**
**  Examples:
**      - Compute("123456 987654", 6) --> "234561 876549"
**      - Compute("123456 987653", 6) --> "234561 356789"
**      - Compute("66443875", 4) --> "44668753"
**      - Compute("66443875", 8) --> "64438756"
**      - Compute("664438769", 8) --> "67834466"
**      - Compute("123456779", 8) --> "23456771"
**      - Compute("", 8) --> ""
**      - Compute("123456779", 0) --> "" 
**      - Compute("5630 00655 7344 6948 5", 4) --> "0365 0650 7345 6944"
****/

using System.Linq;

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class ReverseOrRotate
    {
        public static string Compute(string str, int sz)
        {
            string result = "";
            if (sz <= 0 || str.Length == 0 || str.Length < sz) return "";

            for (int i = 0; i < str.Length; i += sz)
            {
                if (i > str.Length - sz) return result;
                string chunk = str.Substring(i, sz);
                int num = int.Parse(chunk);
                
                var list = new Stack<int>(32);
                do
                {
                    list.Push(num % 10);
                    num /= 10;
                } while (num != 0);

                int[] digits = list.ToArray();
                int sum = 0;
                
                for (int j = 0; j < digits.Length; j++)
                {
                    digits[j] *= digits[j] * digits[j];
                    sum += digits[j];
                }
                
                if (sum % 2 == 0)
                {
                    chunk = Reverse(chunk);
                }
                else
                {
                    char c = chunk[0];
                    char[] arr = chunk.ToCharArray();
                    for (int j = 0; j < arr.Length - 1; j++) arr[j] = arr[j + 1];
                    arr[arr.Length - 1] = c;
                    chunk = new string(arr);
                }

                result += chunk;
            }

            return result;
        }

        public static string Reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}