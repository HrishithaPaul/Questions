using System;

public class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }
}

public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }

    public double DesktopPriceCalculation()
    {
        int processorCost = GetProcessorCost(Processor);
        return processorCost +
               (RamSize * 200) +
               (HardDiskSize * 1500) +
               (GraphicCard * 2500) +
               (MonitorSize * 250) +
               (PowerSupplyVolt * 20);
    }

    private int GetProcessorCost(string processor)
    {
        switch (processor.ToUpper())
        {
            case "I3":
                return 1500;
            case "I5":
                return 3000;
            case "I7":
                return 4500;
            default:
                return 0;
        }
    }
}

public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }

    public double LaptopPriceCalculation()
    {
        int processorCost = GetProcessorCost(Processor);
        return processorCost +
               (RamSize * 200) +
               (HardDiskSize * 1500) +
               (GraphicCard * 2500) +
               (DisplaySize * 250) +
               (BatteryVolt * 20);
    }

    private int GetProcessorCost(string processor)
    {
        switch (processor.ToUpper())
        {
            case "I3":
                return 2500;
            case "I5":
                return 5000;
            case "I7":
                return 6500;
            default:
                return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.Write("Choose the option: ");
        int choice = int.Parse(Console.ReadLine());

        Computer computer;
        if (choice == 1)
        {
            computer = new Desktop();
        }
        else if (choice == 2)
        {
            computer = new Laptop();
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        Console.Write("Enter the processor: ");
        computer.Processor = Console.ReadLine();

        Console.Write("Enter the ram size: ");
        computer.RamSize = int.Parse(Console.ReadLine());

        Console.Write("Enter the hard disk size: ");
        computer.HardDiskSize = int.Parse(Console.ReadLine());

        Console.Write("Enter the graphic card size: ");
        computer.GraphicCard = int.Parse(Console.ReadLine());

        if (computer is Desktop)
        {
            Console.Write("Enter the monitor size: ");
            ((Desktop)computer).MonitorSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the power supply volt: ");
            ((Desktop)computer).PowerSupplyVolt = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.Write("Enter the display size: ");
            ((Laptop)computer).DisplaySize = int.Parse(Console.ReadLine());

            Console.Write("Enter the battery volt: ");
            ((Laptop)computer).BatteryVolt = int.Parse(Console.ReadLine());
        }

        double price;
        if (computer is Desktop)
        {
            price = ((Desktop)computer).DesktopPriceCalculation();
        }
        else
        {
            price = ((Laptop)computer).LaptopPriceCalculation();
        }

        Console.WriteLine(choice == 1 ? $"Desktop price is {price}" : $"Laptop price is {price}");
    }
}