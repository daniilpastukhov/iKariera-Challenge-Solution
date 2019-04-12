/****
**  Write a function called that takes a string of parentheses,
**  and determines if the order of the parentheses is valid. 
**
**  The function should return true if the string is valid, and false if it's invalid.
**
**  Examples
**
**      "()"               =>  true
**      ")(()))"           =>  false
**      "("                =>  false
**      "(())((()())())"   =>  true
**      "()()()()()()()"   => true
**      "())()()()()()(()" => false
**
**  Constraints
**      - 0 <= input.length <= 100
**      - along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters.
**      - the input string may be empty and/or not contain any parentheses at all.
**      - do not treat other forms of brackets as parentheses (e.g. [], {}, <>).
****/

using System.Collections;

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class ValidParentheses
    {
        public static bool FindValidParentheses(string input)
        {
            if (input.Length == 1) return false;
            var stack = new Stack<char>();

            foreach (var i in input)
            {
                if (i == '(') stack.Push(i);
                else if (i == ')')
                {
                    if (stack.Count == 0) return false;
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
