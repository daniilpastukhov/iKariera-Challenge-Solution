/****
**  The function IsComplex() that takes one string argument and
**  returns true or false depending on if the string is an valid complex number.
**  Per Wikipedia, a complex number is a number that can be expressed in the form a + bi,
**  where a and b are real numbers, and i is a solution of the equation x² = −1. 
**  Because no real number satisfies this equation, i is called an imaginary number.
**
**  IsComplex("5+2i") => true
**  IsComplex("5") => false
**
**  Notes:
**      - you are NOT allowed to use the System.Convert class, int.Parse
**        or any other class that converts the string for you
**      - you are NOT allowed to cast to int and catch exception
**      - you MUST figure out a way to parse this by iterating the characters
****/

using System.Linq;

namespace CodingChallenges
{
    using System;

    public static class Complex
    {
        public static bool IsComplex(string number)
        {
            if (!number.Contains('i')) return false; // if the number doesn't contain i, so it can't be a complex number
            char[] allowedChars = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '/', '*', '.', ' ', 'i'};

            foreach (var i in number)
            {
                if (!allowedChars.Contains(i)) return false;
            }
            
            return true;
        }
    }
}