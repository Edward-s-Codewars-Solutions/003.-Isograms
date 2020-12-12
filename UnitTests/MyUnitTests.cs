using KataLibrary;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class MyUnitTests
{
    private static IEnumerable<TestCaseData> TestCasesForValidation
    {
        get
        {
            yield return new TestCaseData("Dermatoglyphics").Returns(true);
            yield return new TestCaseData("isogram").Returns(true);
            yield return new TestCaseData("moose").Returns(true);
            yield return new TestCaseData("isIsogram").Returns(true);
            yield return new TestCaseData("aba").Returns(true);
            yield return new TestCaseData("moOse").Returns(true);
            yield return new TestCaseData("thumbscrewjapingly").Returns(true);
            yield return new TestCaseData("").Returns(true);
            yield return new TestCaseData("word1").Returns(false);
            yield return new TestCaseData("w2ord1").Returns(false);
            yield return new TestCaseData("3").Returns(false);
            yield return new TestCaseData(" ").Returns(false);
            yield return new TestCaseData("word with spaces").Returns(false);
            yield return new TestCaseData("abcd@").Returns(false);
        }
    }

    [Test, TestCaseSource("testCasesForValidation")]
    public bool Are_words_validated_correctly(string str) =>
        StringHelper.IsValidWord(str);

    private static IEnumerable<TestCaseData> TestCasesForDistinctLetters
    {
        get
        {
            yield return new TestCaseData("abcd").Returns(true);
            yield return new TestCaseData("aabcd").Returns(false);
            yield return new TestCaseData("qQdsa").Returns(false);
            yield return new TestCaseData("aAbCd").Returns(false);
            yield return new TestCaseData("xyzasdf").Returns(true);
        }
    }

    [Test, TestCaseSource("testCasesForDistinctLetters")]
    public bool Are_letter_distinction_tested_correctly(string str) =>
        StringHelper.HasNoRepeatingCharacters(str);
}
