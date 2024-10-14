using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string str = Console.ReadLine();

            string strModified = "";
            bool isUpperCase = true;

            foreach (char c in str)
            {
                if (isUpperCase)
                {
                    strModified += char.ToUpper(c);
                }
                else
                {
                    strModified += char.ToLower(c);
                }

                isUpperCase = !isUpperCase
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    strModified += char.ToUpper(str[i]);
                }
                else
                {
                    strModified += char.ToLower(str[i]);
                }
            }

            Console.WriteLine(strModified);
        }
    }
}