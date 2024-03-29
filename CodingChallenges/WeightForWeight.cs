﻿/****
**  My friend John and I are members of the "Fat to Fit Club (FFC)".
**  John is worried because each month a list with the weights of
**  members is published and each month he is the last on the list
**  which means he is the heaviest.
**
**  I am the one who establishes the list so I told him: "Don't
**  worry any more, I will modify the order of the list".
**  It was decided to attribute a "weight" to numbers. The weight
**  of a number will be from now on the sum of its digits.
**
**  For example 99 will have "weight" 18, 100 will have "weight" 1
**  so in the list 100 will come before 99. Given a string with the
**  weights of FFC members in normal order can you give this string
**  ordered by "weights" of these numbers?
**
**  Example:
**      "56 65 74 100 99 68 86 180 90" ordered by numbers weights becomes:
**          "100 180 90 56 65 74 68 86 99"
**
**  When two numbers have the same "weight", let us class them as
**  if they were strings and not numbers: 100 is before 180 because
**  its "weight" (1) is less than the one of 180 (9) and 180 is before
**  90 since, having the same "weight" (9) it comes before as a string.
**
**  All numbers in the list are positive numbers and the list can be empty.
**
**  Notes
**      - it may happen that the input string have leading, trailing whitespaces
**        and more than a unique whitespace between two consecutive numbers
**      - don't modify the input
****/

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class WeightForWeight
    {
        public static string OrderByWeight(string str)
        {
            var pairs = new List<KeyValuePair<int, int>>();
            int sumOfDigits = 0;
            string number = "";
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') continue;
                if (str[i] >= '0' && str[i] <= '9')
                {
                    sumOfDigits += str[i] - '0';
                    number += str[i];
                    if (i != str.Length - 1 && str[i + 1] == ' ')
                    {
                        pairs.Add(new KeyValuePair<int, int>(int.Parse(number), sumOfDigits));
                        sumOfDigits = 0;
                        number = "";
                    }
                    else if (i == str.Length - 1)
                    {
                        pairs.Add(new KeyValuePair<int, int>(int.Parse(number), sumOfDigits));
                    }
                }
            }

            pairs.Sort((x, y) =>
            {
//                if (x.Value == y.Value) return y.Key.CompareTo(x.Key);
                return x.Value.CompareTo(y.Value);
            });

            for (int i = 0; i < pairs.Count; i++)
            {
                result += pairs[i].Key + " ";
            }

            result = result.Substring(0, result.Length - 1);

            return result;
        }
    }
}