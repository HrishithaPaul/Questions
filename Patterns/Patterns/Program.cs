using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            do
            {
                Console.Write(i);
                Console.Write(" ");
                Console.Write(j);
                Console.WriteLine();
                j++;
                if (j > 2)
                {
                    i++;
                    j = 1;
                }
            }
            while (i < 6);
        }
    }
}
