/* Can you find the needle in the haystack?

Write a function findNeedle() that takes an array full of junk but containing one "needle"

After your function finds the needle it should return a message (as a string) that says:

"found the needle at position " plus the index it found the needle, so:

find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
should return "found the needle at position 5"(in COBOL "found the needle at position 6") */

using System;
public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        int a = 0;
        for (int i = 0; haystack.Length > i; i++)
        {
            if (Convert.ToString(haystack[i]) == "needle")
            {
                a = i;
            }
        }
        return ("found the needle at position " + Convert.ToString(a));
    }
}