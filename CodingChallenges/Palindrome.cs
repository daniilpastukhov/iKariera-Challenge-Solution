/****
**  A palindrome is a word that reads the same backward or forward!
**  Write a function that checks if a given word is a palindrome
**
**  Note: Character case should be ignored.
****/

using System.Linq;

namespace CodingChallenges
{
    using System;

    public static class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            int length = word.Length;
            word = word.ToLower();
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1]) return false;
            }
            
            return true;
        }
    }
}
