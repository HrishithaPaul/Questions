using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q16
{
    public class Book
    {
        private string title;
        private string author;
        private int numPages;
        private DateTime dueDate;
        private DateTime returnedDate;

        public Book()
        {
            // Default constructor
        }

        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        public int AveragePagesReadPerDay(int daysToRead)
        {
            return (int)(numPages / (double)daysToRead);
        }

        public double CalculateLateFee(double dailyLateFeeRate)
        {
            TimeSpan daysLate = returnedDate - dueDate;
            int numberOfDaysLate = daysLate.Days;
            return numberOfDaysLate * dailyLateFeeRate;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            Console.Write("Enter the number of pages: ");
            int numPages = int.Parse(Console.ReadLine());

            Console.Write("Enter the due date (MM/DD/YYYY): ");
            DateTime dueDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

            Console.Write("Enter the return date (MM/DD/YYYY): ");
            DateTime returnedDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

            Console.Write("Enter the days to read: ");
            int daysToRead = int.Parse(Console.ReadLine());

            Console.Write("Enter the daily late fee rate: ");
            double dailyLateFeeRate = double.Parse(Console.ReadLine());

            Book book = new Book(title, author, numPages, dueDate, returnedDate);

            double averagePagesReadPerDay = book.AveragePagesReadPerDay(daysToRead);
            double lateFee = book.CalculateLateFee(dailyLateFeeRate);

            Console.WriteLine("Average Pages Read Per Day: {0}", averagePagesReadPerDay);
            Console.WriteLine("Late Fee: {0}", lateFee);
        }
    }
}

