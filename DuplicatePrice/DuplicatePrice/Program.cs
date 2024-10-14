using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q13
{
    public class Program
    {
        public static void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            bool[] visited = new bool[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                if (!visited[i])
                {
                    for (int j = i + 1; j < chars.Length; j++)
                    {
                        if (chars[i] == chars[j])
                        {
                            chars[j] = specialChar;
                            visited[j] = true;
                        }
                    }
                }
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            char[] chars = new char[size];

            Console.WriteLine("Enter the characters");
            for (int i = 0; i < size; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the special character: ");
            char specialChar = char.Parse(Console.ReadLine());

            ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

            Console.WriteLine("string: ");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }
    }
}

