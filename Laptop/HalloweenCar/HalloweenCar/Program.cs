using System;

class Owner
{
    protected string ownerName;
}

class Car : Owner
{
    internal double price;
    private string bodyStyle;

    public string BodyStyle
    {
        get { return bodyStyle; }
        set { bodyStyle = value; }
    }

    public bool ValidateBodyStyle(string bodyStyle)
    {
        return bodyStyle.Equals("SUV", StringComparison.OrdinalIgnoreCase) || bodyStyle.Equals("Sedan", StringComparison.OrdinalIgnoreCase);
    }

    public double CalculatePrice()
    {
        double discountedPrice = price;

        if (bodyStyle.Equals("SUV", StringComparison.OrdinalIgnoreCase))
        {
            discountedPrice *= 0.9; // 10% discount
        }
        else if (bodyStyle.Equals("Sedan", StringComparison.OrdinalIgnoreCase))
        {
            discountedPrice *= 0.75; // 25% discount
        }

        return discountedPrice;
    }

    public void SetOwnerName(string name)
    {
        ownerName = name;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the owner name: ");
        string ownerName = Console.ReadLine();

        Console.Write("Enter the car body style: ");
        string bodyStyle = Console.ReadLine();

        Console.Write("Enter the price: ");
        double price = double.Parse(Console.ReadLine());

        Car car = new Car();
        car.BodyStyle = bodyStyle;
        car.price = price;

        if (car.ValidateBodyStyle(bodyStyle))
        {
            double finalPrice = car.CalculatePrice();
            car.SetOwnerName(ownerName);

            Console.WriteLine($"The owner sells the {bodyStyle} type car for ${finalPrice}");
        }
        else
        {
            Console.WriteLine("Invalid Car Type");
        }
    }
}