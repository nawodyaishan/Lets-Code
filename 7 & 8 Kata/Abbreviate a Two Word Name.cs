// Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

// The output should be two capital letters with a dot separating them.

// It should look like this:

// Sam Harris => S.H

// patrick feeney => P.F


public class Kata
{
  public static string AbbrevName(string name)
  {
    string result = "";
    string x = name.ToUpper();

    char[] spearator = {' '};
    string[] strlist = x.Split(spearator);

    foreach(string s in strlist)
    {
        result += s[0];
        result +=".";
    }
    string resultNew = result.Remove(result.Length - 1, 1); 

    return resultNew;
  }
}

