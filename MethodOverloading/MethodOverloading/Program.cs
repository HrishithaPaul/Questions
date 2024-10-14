using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q18
{
    public class Product
    {
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            return price * quantity;
        }

        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal discountAmount = price * quantity * discountPercentage / 100m;
            return price * quantity - discountAmount;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Price Without Discount");
            Console.WriteLine("2. Price With Discount");
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product();
            decimal totalPrice;

            if (choice == 1)
            {
                totalPrice = product.CalculateTotalPrice(price, quantity);
            }
            else if (choice == 2)
            {
                Console.Write("Enter the discount percentage: ");
                int discountPercentage = int.Parse(Console.ReadLine());
                totalPrice = product.CalculateTotalPrice(price, quantity, discountPercentage);
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            Console.WriteLine(choice == 1 ? $"Total price without discount {totalPrice}" : $"Total price with discount {totalPrice}");
        }
    }
}


