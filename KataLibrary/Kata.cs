﻿// An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
// Implement a function that determines whether a string that contains only letters is 
// an isogram. Assume the empty string is an isogram. Ignore letter case.

// isIsogram "Dermatoglyphics" == true
// isIsogram "aba" == false
// isIsogram "moOse" == false-- ignore letter case

public static class Kata
{
    public static bool IsIsogram(string word)
    {
        bool output = 
            StringHelper.IsValidWord(word) && 
            StringHelper.HasNoRepeatingCharacters(word);

        return output;
    }
}