/****
**  Build Tower by the following given argument:
**  number of floors (integer and always greater than 0).
**
**  Tower block is represented as *
**
**  Have fun!
**
**  for example, a tower of 3 floors looks like below
**
**      [
**          '  *  ', 
**          ' *** ', 
**          '*****'
**      ]
**
**  and a tower of 6 floors looks like below
**
**      [
**          '     *     ', 
**          '    ***    ', 
**          '   *****   ', 
**          '  *******  ', 
**          ' ********* ', 
**          '***********'
**      ]
****/

namespace CodingChallenges
{
    using System;
    using System.Linq;

    public static class BuildTower
    {
        public static string[] TowerBuilder(int numberOfFloors)
        {
            var result = new string[numberOfFloors];
            var maxWidth = (2 * numberOfFloors) - 1;
            var padding = numberOfFloors - 1;
            
            for (var i = 0; i < numberOfFloors; i++)
            {
                for (var j = 0; j < padding; j++) result[i] += ' ';
                for (var j = 0; j < maxWidth - (padding * 2); j++) result[i] += '*';
                for (var j = 0; j < padding; j++) result[i] += ' ';
                padding--;
            }
            
            return result;
        }
    }
}
