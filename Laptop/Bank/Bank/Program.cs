using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public decimal Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }

                Balance += amount;
                return Balance;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return Balance;
            }
        }

        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }

                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }

                Balance -= amount;
                return Balance;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return Balance;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return Balance;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter the balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Account account = new Account
            {
                AccountNumber = accountNumber,
                Balance = balance
            };

            Console.Write("Enter the amount to be ");
            if (choice == 1)
            {
                Console.WriteLine("deposit");
            }
            else
            {
                Console.WriteLine("withdraw");
            }
            Console.Write(": ");
            decimal amount = decimal.Parse(Console.ReadLine());

            decimal newBalance;

            if (choice == 1)
            {
                newBalance = account.Deposit(amount);
            }
            else
            {
                newBalance = account.Withdraw(amount);
            }

            Console.WriteLine("Balance amount " + newBalance);
        }
    }
}
