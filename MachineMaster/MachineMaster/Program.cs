using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Q20
{

    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; protected set; }

        public bool ValidateEmployeeId()
        {
            if (Id.Length != 5 || !Id.StartsWith("EM") || !int.TryParse(Id.Substring(2), out int _))
            {
                return false;
            }
            return true;
        }

        public abstract Employee SalaryCalculation();
    }

    public class Permanent : Employee
    {
        public double BasicPay { get; set; }

        public override Employee SalaryCalculation()
        {
            Salary = BasicPay + 0.5 * BasicPay + 0.3 * BasicPay;
            return this;
        }
    }

    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages;
            return this;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Permanent");
            Console.WriteLine("2.Temporary");
            Console.Write("Choose the employee type: ");
            int choice = int.Parse(Console.ReadLine());

            Employee employee;
            if (choice == 1)
            {
                employee = new Permanent();
            }
            else if (choice == 2)
            {
                employee = new Temporary();
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            Console.Write("Enter the employee id: ");
            employee.Id = Console.ReadLine();

            if (!employee.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
                return;
            }

            Console.Write("Enter the name: ");
            employee.Name = Console.ReadLine();

            if (employee is Permanent)
            {
                Console.Write("Enter basic pay: ");
                ((Permanent)employee).BasicPay = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Enter hours worked: ");
                ((Temporary)employee).HrsWorked = int.Parse(Console.ReadLine());

                Console.Write("Enter hourly wages: ");
                ((Temporary)employee).HrlyWages = int.Parse(Console.ReadLine());
            }

            employee = employee.SalaryCalculation();

            Console.WriteLine($"Employee id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}");
        }
    }
}


