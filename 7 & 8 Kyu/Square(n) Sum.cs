/* Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9. */

public static class Kata
{
    public static int SquareSum(int[] n)
    {
        int result = 0;
        int x = n.Length;
        result = x > 0 ? ArSum(n) : 0;
        return result;
    }

    public static int ArSum(int[] n)
    {
        int sum = 0;
        int y = n.Length;
        int[] s = new int[y];
        for (int i = 0; y > i; i++)
        {
            s[i] = n[i] * n[i];
            sum += s[i];
        }
        return sum;
    }
}

