/* The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.

Task
Given a year, return the century it is in.

Examples
1705 --> 18
1900 --> 19
1601 --> 17
2000 --> 20 */



public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        int result = 0;
        int m = year % 100;

        if (m > 0)
        {
            result = (year / 100) + 1;
            return result;
        }

        else
        {
            result = (year / 100);
            return result;
        }
    }
}
