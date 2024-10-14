using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q10
{
    public class Program
    {
        public static int[] FindStudentsRank(int[,] stdMarks)
        {
            int[] totalMarks = new int[stdMarks.GetLength(0)];
            int[] ranks = new int[stdMarks.GetLength(0)];

            // Calculate total marks for each student
            for (int i = 0; i < stdMarks.GetLength(0); i++)
            {
                for (int j = 0; j < stdMarks.GetLength(1); j++)
                {
                    totalMarks[i] += stdMarks[i, j];
                }
            }

            // Determine ranks
            for (int i = 0; i < stdMarks.GetLength(0); i++)
            {
                ranks[i] = 1;
                for (int j = 0; j < stdMarks.GetLength(0); j++)
                {
                    if (totalMarks[j] > totalMarks[i])
                    {
                        ranks[i]++;
                    }
                }
            }

            return ranks;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            int[,] stdMarks = new int[numStudents, 5];

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}");
                for (int j = 0; j < 5; j++)
                {
                    stdMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] ranks = FindStudentsRank(stdMarks);

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Rank of student {i + 1} is {ranks[i]}");
            }
        }
    }
}
