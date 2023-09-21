using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Finding_longes_word 
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Prompt the user for the path to the text file
            Console.Write("Enter the path to the text file: ");
            string filePath = Console.ReadLine();

            try
            {
                // Read the text file
                string text = File.ReadAllText(filePath);

                // Tokenize the text into words using whitespace as a delimiter
                string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                // Find the longest words
                List<string> longestWords = FindLongestWords(words);

                // Display the longest words
                Console.WriteLine("Longest words in the text:");
                foreach (string word in longestWords)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static List<string> FindLongestWords(string[] words)
        {
            // Find the length of the longest word
            int maxLength = words.Max(word => word.Length);

            // Filter words with the maximum length
            List<string> longestWords = words.Where(word => word.Length == maxLength).ToList();

            return longestWords;
        }
    }
}
