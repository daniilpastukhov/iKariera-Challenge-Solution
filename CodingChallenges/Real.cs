/****
**  The function IsReal() that takes one string argument and
**  returns true or false depending on if the string is an valid real number.
**  Per Wikipedia, a real number is a value of a continuous quantity 
**  that can represent a distance along a line
**
**  IsReal("5") => true
**  IsReal("3.14") => true
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

    public static class Real
    {
        public static bool IsReal(string number)
        {
            char[] allowedChars = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', '-', ' '};
            bool metComma = false, metSign = false;
            bool waitForNumber = false;

            foreach (var i in number)
            {
                if (!allowedChars.Contains(i)) return false;
                if (waitForNumber)
                    if (i >= '0' && i <= '9')
                        waitForNumber = false;
                    else
                        return false;
                switch (i)
                {
                    case '.' when metComma:
                        return false;
                    case '.':
                        waitForNumber = true;
                        metComma = true;
                        break;
                    case '-' when metSign:
                        return false;
                    case '-':
                        waitForNumber = true;
                        metSign = true;
                        break;
                }
            }

            return (!waitForNumber);
        }
    }
}