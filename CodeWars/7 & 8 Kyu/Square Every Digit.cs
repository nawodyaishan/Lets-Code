/* Welcome.In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer */

using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string result = string.Empty;
        foreach (char x in n.ToString())
        {
            int resultNum = int.Parse(x.ToString());
            result += (Math.Pow(resultNum, 2));
        }
        return int.Parse(result);
    }
}
