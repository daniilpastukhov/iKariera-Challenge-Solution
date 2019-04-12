# iKariera-Challenge-Solution
My solution to iKariera Challenge problems.

The second assert in *WeightForWeightTest.cs* seems to be wrong.<br>
**"2000 10003 1234000 44444444 9999 11 11 22 123"** is an input string.<br>
**"11 11 2000 10003 22 123 1234000 44444444 9999"** is meant to be an output, but the task says that in case 2 numbers have the same weight, sort them by the order they appear in the input string.<br>
So I think it should look like **"2000 11 11 10003 22 123 1234000 44444444 9999"**, because 2000 and 11 have the same weight, but 2000 appears earlier than 11.
