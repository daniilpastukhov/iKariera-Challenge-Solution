/****
**  Write a function that takes in a string of one or more words,
**  and returns the same string, but with all five or more letter
**  words reversed (Just like the name of this class). Strings passed
**  in will consist of only letters and spaces. Spaces will be included
**  only when more than one word is present.
**
**  Examples:
**      - SpinWords("Hey fellow warriors")   ->   "Hey wollef sroirraw"
**      - SpinWords("This is a test")        ->   "This is a test"
**      - SpinWords("This is another test")  ->   "This is rehtona test"
****/

namespace CodingChallenges
{
    using System;

    public static class StopGninnipsMySdrow
    {
        public static string SpinWords(string sentence)
        {
            string[] split = sentence.Split(" ");
            string result = "";

            foreach (var i in split)
            {
                if (i.Length >= 5)
                {
                    result += Reverse(i) + " ";
                }
                else
                {
                    result += i + " ";
                }
            }

            result = result.Substring(0, result.Length - 1);

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