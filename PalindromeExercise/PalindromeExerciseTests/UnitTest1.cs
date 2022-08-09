using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void PalindromeTest(string word, bool expected)
        {
            var tester = new WordSmith();
            var actual = tester.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
