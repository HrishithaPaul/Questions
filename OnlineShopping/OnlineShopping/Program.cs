using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q9
{
    public class Program
    {
        public static string UpdatePrice(string[] details, int id, double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                string[] productDetails = details[i].Split(':');
                int productId = int.Parse(productDetails[0]);

                if (productId == id)
                {
                    productDetails[2] = amount.ToString();
                    return productDetails[1] + " " + productDetails[2];
                }
            }

            return "";
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());


            string[] productDetails = new string[numberOfProducts];

            Console.WriteLine("Enter the product details (format: id:name:price):");
            for (int i = 0; i < numberOfProducts; i++)
            {
                productDetails[i] = Console.ReadLine();
            }

            Console.Write("Enter the product id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount to update: ");
            double amount = double.Parse(Console.ReadLine());

            string updatedProduct = UpdatePrice(productDetails, productId, amount);

            if (updatedProduct != "")
            {
                Console.WriteLine(updatedProduct);
            }
            else
            {
                Console.WriteLine("Invalid id");
            }
        }

    }
}
