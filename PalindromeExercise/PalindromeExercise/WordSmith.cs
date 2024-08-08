using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            // Convert the string to lowercase and remove whitespace
            var processedInput = input.ToLower().Replace(" ", "");

            // Reverse the string
            var reversedInput = new string(processedInput.Reverse().ToArray());

            // Check if the processed string is equal to the reversed string
            return processedInput == reversedInput;
        }
    }
}