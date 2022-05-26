/* 
Given a number n, draw stairs using the letter "I", n tall and n wide, with the tallest in the top left.
 */



public class Kata
{
    public static string DrawStairs(int n)
    {
        var result = "";
        for (int i = 1; i < n; i++)
        {
            result += "I\n" + new string(' ', i);
        }

        return result + "I";
    }
}