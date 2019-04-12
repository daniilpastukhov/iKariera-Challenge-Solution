/****
**  Move the first letter of each word to the end of it, then add "ay"
**  to the end of the word. Leave punctuation marks untouched.
**
**
**  PigIt("Pig latin is cool") ->   igPay atinlay siay oolcay
**  PigIt("Hello world !");    ->   elloHay orldWay !
**
**
**  https://en.wikipedia.org/wiki/Pig_Latin
****/

using System.Linq;
using System.Xml.XPath;

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class PigLatin
    {
        public static string PigIt(string str)
        {
            string[] split = str.Split(' ');
            string result = ""; 

            foreach (var i in split)
            {
                result += i.Substring(1, i.Length - 1);
                result += i[0] + "ay ";
            }

            result = result.Remove(result.Length - 1);
            
            return result;
        }
    }
}
