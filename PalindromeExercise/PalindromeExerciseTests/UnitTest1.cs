using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // A palindrome
        [InlineData("Racecar", true)] // Case insensitive palindrome
        [InlineData("hello", false)] // Not a palindrome
        [InlineData("A man a plan a canal Panama", true)] // Palindrome with spaces
        [InlineData("No lemon, no melon", true)] // Another palindrome with spaces
        public void IsAPalindromeTest(string input, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith();

            // Act
            var actual = wordSmith.IsAPalindrome(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}