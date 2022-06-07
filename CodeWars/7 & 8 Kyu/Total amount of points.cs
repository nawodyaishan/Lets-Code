/* Our football team finished the championship. The result of each match look like "x:y". Results of all matches are recorded in the collection.

For example: ["3:1", "2:2", "0:1", ...]

Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:

if x > y: 3 points
if x < y: 0 point
if x = y: 1 point
Notes:

there are 10 matches in the championship
0 <= x <= 4
0 <= y <= 4 */

using System.Linq;
using System;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        int totalPoints = 0;

        foreach (var score in games)
        {
            int x = Convert.ToInt32(score.Substring(0, 1));
            int y = Convert.ToInt32(score.Substring(2, 1));

            if (x > y)
                totalPoints += 3;

            else if (x < y)
                totalPoints += 0;

            else if (x == y)
                totalPoints += 1;
        }

        return totalPoints;
    }
}

/* 
using System.Linq;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
    }
} 

*/