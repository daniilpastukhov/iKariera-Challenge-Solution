﻿/****
**  Some numbers have funny properties. For example:
**
**  89 --> 8¹ + 9² = 89 * 1
**  695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2
**  46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
**
**  Given a positive integer n written as abcd... (a, b, c, d... being digits) and
**  positive integer p we want to find a positive integer k, if it exists, such as
**  the sum of the digits of n taken to the successive powers of p is equal to k * n. In other words:
**
**  Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n * k
**
**  If it is the case we will return k, if not return -1.
**
**  Note: n, p will always be given as strictly positive integers.
**
**  ComputeNumber(89, 1) should return 1 since 8¹ + 9² = 89 = 89 * 1
**  ComputeNumber(92, 1) should return -1 since there is no k such as 9¹ + 2² equals 92 * k
**  ComputeNumber(695, 2) should return 2 since 6² + 9³ + 5⁴= 1390 = 695 * 2
**  ComputeNumber(46288, 3) should return 51 since 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
****/

using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingChallenges
{
    public static class PlayingWithDigits
    {
        public static long ComputeNumber(int number, int startingPower)
        {
            int copiedNumber = number;
            long bigNumber = 0;


            var list = new Stack<int>(32);
            do
            {
                list.Push(copiedNumber % 10);
                copiedNumber /= 10;
            } while (copiedNumber != 0);

            int[] arr = list.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bigNumber += (long) Math.Pow(double.Parse(arr[i].ToString()), (double) startingPower++);
            }

            return (bigNumber % number == 0) ? bigNumber / number : -1;
        }
    }
}