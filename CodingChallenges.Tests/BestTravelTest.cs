using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class BestTravelTest
    {
        [Fact]
        public void TestBestTravel()
        {
            var distances = new List<int> { 50, 55, 56, 57, 58 };
            int? n = BestTravel.ChooseBestSum(163, 3, distances);
            Assert.Equal(163, n);

            distances = new List<int> { 50 };
            n = BestTravel.ChooseBestSum(163, 3, distances);
            Assert.Equal(null, n);

            distances = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = BestTravel.ChooseBestSum(230, 3, distances);
            Assert.Equal(228, n); // we can get 229 (which is less than 230) with 74, 74 and 81
//            Assert.Equal(229, n);
        }
    }
}
