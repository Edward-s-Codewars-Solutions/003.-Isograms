using System;

public class Kata
{
    public static bool IsIsogram(string word)
    {
        if (StringHelper.IsValidWord(word) == false)
            throw new Exception("The provided word is invalid.");


    }
}

public static class StringHelper
{
    public static bool IsValidWord(string word)
    {
        throw new NotImplementedException();
    }
}