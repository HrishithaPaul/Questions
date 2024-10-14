using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q11
{
    public class Program
    {
        public static string FindWhoGotMaximumPoints(int[][] points)
        {
            int[] totalPoints = new int[points.Length];

            // Calculate total points for each student
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points[i].Length; j++)
                {
                    totalPoints[i] += points[i][j];
                }
            }

            // Find the student with maximum points
            int maxPointsIndex = 0;
            for (int i = 1; i < points.Length; i++)
            {
                if (totalPoints[i] > totalPoints[maxPointsIndex])
                {
                    maxPointsIndex = i;
                }
            }

            return $"Student {maxPointsIndex + 1} got maximum points";
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            int[][] points = new int[numStudents][];

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i + 1}");
                int numCompetitions = int.Parse(Console.ReadLine());

                points[i] = new int[numCompetitions];

                Console.WriteLine($"Enter the student {i + 1} points");
                for (int j = 0; j < numCompetitions; j++)
                {
                    points[i][j] = int.Parse(Console.ReadLine());
                }
            }

            string result = FindWhoGotMaximumPoints(points);
            Console.WriteLine(result);
        }
    }
}


