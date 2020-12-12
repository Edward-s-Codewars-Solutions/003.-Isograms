// An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
// Implement a function that determines whether a string that contains only letters is 
// an isogram. Assume the empty string is an isogram. Ignore letter case.

// isIsogram "Dermatoglyphics" == true
// isIsogram "aba" == false
// isIsogram "moOse" == false-- ignore letter case

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool IsIsogram(string word)
    {
        bool output = 
            StringHelper.IsValidWord(word) && 
            StringHelper.HasNoRepeatingCharacters(word);

        return output;
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

    public static bool HasNoRepeatingCharacters(string word)
    {
        char[] wordAsCharArray = word
            .ToUpper()
            .ToCharArray();
        char[] wordAsDistinctCharArray = wordAsCharArray
            .Distinct()
            .ToArray();

        bool output = wordAsCharArray.Length == wordAsDistinctCharArray.Length;

        return output;
    }
}