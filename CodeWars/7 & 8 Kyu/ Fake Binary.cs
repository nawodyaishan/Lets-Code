// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

// Note: input will never be an empty string

public class Kata
{
    public static string FakeBin(string x)
    {
        string result = "";
        for (int i = 0; i < x.Length; i++)
        {
            result += (x[i] < '5') ? 0 : 1;
        }
        return result;
    }
}