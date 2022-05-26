/* 
Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false. */



using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        string x;
        if (word == true)
        {
            x = "Yes";
        }
        else
        {
            x = "No";
        }
        return x;
    }
}