using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q12
{
    public class Program
    {
        public static object CalculateDiscountedPrice(object totalCost)
        {
            double totalCostDouble = (double)totalCost;

            double discountPercentage;
            if (totalCostDouble >= 1000)
            {
                discountPercentage = 0.3;
            }
            else if (totalCostDouble >= 500)
            {
                discountPercentage = 0.15;
            }
            else
            {
                discountPercentage = 0.05;
            }

            double discountedPrice = totalCostDouble - (totalCostDouble * discountPercentage);

            return (object)discountedPrice;
        }

        public static void Main()
        {
            Console.WriteLine("Enter the total cost: ");
            double totalCost = double.Parse(Console.ReadLine());

            object discountedPrice = CalculateDiscountedPrice((object)totalCost);

            Console.WriteLine("Price after discount is " + discountedPrice);
        }
    }
}
