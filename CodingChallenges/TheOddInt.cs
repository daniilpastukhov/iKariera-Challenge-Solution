/****
**  Given an array, find the int that appears an odd number of times.
**
**  Note: There will always be only one integer that appears an odd number of times.
****/

using System.Collections.Generic;

namespace CodingChallenges
{
    using System;
    using System.Linq;

    public static class TheOddInt
    {
        public static int Find(int[] sequence)
        {
            var dictionary = new Dictionary<int, int>(sequence.Length);
            
            foreach (var i in sequence)
            {
                if (dictionary.ContainsKey(i))
                {
                    var val = dictionary[i];
                    val++;
                    dictionary.Remove(i);
                    dictionary.Add(i, val);
                }
                else
                {
                    dictionary.Add(i, 1);
                }
            }

            int index = 0, value = dictionary.First().Value;

            foreach (var i in dictionary)
            {
                if (i.Value > value)
                {
                    index = i.Key;
                    value = i.Value;
                }
            }
            
            return index;
        }
    }
}
