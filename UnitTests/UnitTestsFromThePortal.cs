// Unit tests in this file were just copied from Codewars portal

using KataLibrary;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace UnitTests
{
    [TestFixture]
    public class BasicTests
    {
        [Test, TestCaseSource("TestCases")]
        public bool Test(string str) => Kata.IsIsogram(str);

        [SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "It is used by UT method")]
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }
    }
}