//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment6.FrequencyOfWord
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Enter the string: ");
//            string input = Console.ReadLine();

//            if (input.Length % 2 != 0)
//            {
//                Console.WriteLine("Invalid length");
//                return;
//            }

//            Dictionary<string, int> wordCount = new Dictionary<string, int>();

//            string[] words = input.Split(':');

//            for (int i = 0; i < words.Length; i += 2)
//            {
//                string word = words[i].ToUpper();
//                int count = int.Parse(words[i + 1]);

//                if (wordCount.TryGetValue(word, out int currentCount))
//                {
//                    wordCount[word] = currentCount + count;
//                }
//                else
//                {
//                    wordCount[word] = count;
//                }
//            }

//            foreach (var word in wordCount)
//            {
//                Console.WriteLine($"{word.Key}:{word.Value}");
//            }
//        }
//    }
//}


