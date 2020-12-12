using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool IsIsogram(string word)
    {
        if (StringHelper.IsValidWord(word) == false)
            throw new Exception("The provided word is invalid.");

        throw new NotImplementedException();
    }
}

public static class StringHelper
{
    public static bool IsValidWord(string word)
    {
        string pattern = "^[A-Za-z]*$";
        bool output = Regex.IsMatch(word, pattern);
        return output;
    }
}