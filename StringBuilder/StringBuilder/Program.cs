using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace StringManipulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Step 1: Get input values from the user
            Console.WriteLine("Enter the word 1:");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Enter the character to search:");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after character input

            Console.WriteLine("Enter the word 2:");
            string word2 = Console.ReadLine();

            // Step 2: Call the method WordInserting
            StringBuilder result = WordInserting(word1, ch, word2);

            // Step 3: Display the output result
            Console.WriteLine("Output Result:");
            Console.WriteLine(result.ToString());
        }

        // Method to insert word2 in the position of character ch in word1
        public static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            // Find the index of the character ch in word1
            int index = word1.ToString().IndexOf(ch);

            // If the character is found, insert word2 at that index
            if (index != -1)
            {
                word1.Insert(index, word2);
            }

            // Return the modified StringBuilder
            return word1;
        }
    }
}