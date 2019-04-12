/****
**  John and Mary want to travel between a few towns A, B, C ...
**  Mary has on a sheet of paper a list of distances between these towns.
**  'distances' = [50, 55, 57, 58, 60]. John is tired of driving and he says to Mary
**  that he doesn't want to drive more than 'maxDistance' = 174 miles and he will visit only 3 towns.
**
**  Which distances, hence which towns, they will choose so that the sum of the
**  distances is the biggest possible to please Mary - but less than 'maxDistance' - to please John- ?
**
**  Example:
**  With list 'distances' and 3 towns to visit they can make a choice between:
**  [50,55,57], [50,55,58], [50,55,60], [50,57,58], [50,57,60], [50,58,60],
**  [55,57,58], [55,57,60], [55,58,60], [57,58,60].
**
**  The sums of distances are then: 162, 163, 165, 165, 167, 168, 170, 172, 173, 175.
**
**  The biggest possible sum taking a limit of 174 into account is then 173 and the
**  distances of the 3 corresponding towns is [55, 58, 60].
**
**  The function ChooseBestSum will take as parameters:
**      - 'maxDistance' (maximum sum of distances, integer >= 0)
**      - 'numberOfTowns' (number of towns to visit, integer >= 1)
**      - 'distances' (list of distances, all distances 
**         are positive or null integers and this list has at least one element)
**
**  The function returns the "best" sum ie the biggest possible sum of k distances
**  less than or equal to the given limit 'maxDistance', if that sum exists, or otherwise null.
**
**  Examples:
**  distances = [50, 55, 56, 57, 58] ChooseBestSum(163, 3, distances) -> 163
**  distances = [50] ChooseBestSum(163, 3, distances) -> null
**  distances = [91, 74, 73, 85, 73, 81, 87] ChooseBestSum(230, 3, distances) -> 228
**
**  https://en.wikipedia.org/wiki/Subset_sum_problem
****/

using System.ComponentModel.Design;

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class BestTravel
    {
        public static int? ChooseBestSum(int maxDistance, int numberOfTowns, List<int> distances)
        {
            if (distances.Sum() < maxDistance)
                return null; // check if we can even get a number greater than maxDistance with all numbers

            IEnumerable<IEnumerable<int>> result = GetKCombs(distances, numberOfTowns);

            var list = new List<int>();

            foreach (var i in result)
            {
                list.Add(i.Sum());
            }

            int max = int.MinValue;

            foreach (var i in list)
            {
                if (i > max && i <= maxDistance) max = i;
            }

            return max;
        }

        static IEnumerable<IEnumerable<T>> GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] {t});
            return GetKCombs(list, length - 1).SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                (t1, t2) => t1.Concat(new T[] {t2}));
        }
    }
}