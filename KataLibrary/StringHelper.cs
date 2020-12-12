using System.Linq;
using System.Text.RegularExpressions;

namespace KataLibrary
{
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
}