using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordSmith = new WordSmith();

            // Manually testing the IsAPalindrome method
            string[] testInputs = { "racecar", "Racecar", "hello", "A man a plan a canal Panama", "No lemon, no melon" };

            foreach (var input in testInputs)
            {
                bool result = wordSmith.IsAPalindrome(input);
                Console.WriteLine($"Is \"{input}\" a palindrome? {result}");
            }
        }
    }
}