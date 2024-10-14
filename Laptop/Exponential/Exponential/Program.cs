//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment6.Question7
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Choose an option:");
//            Console.WriteLine("1. Find Exponential");
//            Console.WriteLine("2. Replace Word");

//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Enter the number: ");
//                    int number = int.Parse(Console.ReadLine());
//                    StringBuilder exponentialResult = FindExponential(number);
//                    Console.WriteLine(exponentialResult.ToString());
//                    break;

//                case 2:
//                    Console.Write("Enter a sentence: ");
//                    string sentence = Console.ReadLine();

//                    Console.Write("Enter the word to replace: ");
//                    string word1 = Console.ReadLine();

//                    Console.Write("Enter the replacement word: ");
//                    string word2 = Console.ReadLine();

//                    StringBuilder replacedSentence = ReplaceWord(sentence, word1, word2);
//                    Console.WriteLine(replacedSentence.ToString());
//                    break;

//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//        public static StringBuilder FindExponential(int number)
//        {
//            StringBuilder result = new StringBuilder("Exponential is ");
//            double exponential = Math.Pow(number, 2); // Calculate the square of the number
//            result.Append(exponential.ToString("E6")); // Format the result to 6 decimal places in scientific notation
//            return result;
//        }

//        public static StringBuilder ReplaceWord(string sentence, string word1, string word2)
//        {
//            StringBuilder result = new StringBuilder(sentence);
//            int index = result.ToString().IndexOf(word1); // Convert to string and find index
//            if (index >= 0)
//            {
//                result.Remove(index, word1.Length);
//                result.Insert(index, word2);
//            }
//            return result;
//        }
//    }
//}
