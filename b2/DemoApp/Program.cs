using Office;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Staff> staffList = new List<Staff>();

        Console.Write("Enter the number of staff members to create: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter details for staff member {0}: ", i + 1);
            Console.Write("Enter '1' for FullTimeStaff or '2' for PartTimeStaff: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            if (choice == 1)
            {
                Console.Write("Enter Department: ");
                string department = Console.ReadLine();
                Console.Write("Enter Salary: ");
                double salary = double.Parse(Console.ReadLine());

                staffList.Add(new FullTimeStaff(name, address, department, salary));
            }
            else if (choice == 2)
            {
                Console.Write("Enter Number of Hours: ");
                int numberOfHours = int.Parse(Console.ReadLine());
                Console.Write("Enter Rate per Hour: ");
                double ratePerHour = double.Parse(Console.ReadLine());

                staffList.Add(new PartTimeStaff(name, address, numberOfHours, ratePerHour));
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                i--; // Repeat this iteration
            }
        }

        Console.WriteLine("\nDetails of FullTimeStaff members:");
        foreach (var staff in staffList)
        {
            if (staff is FullTimeStaff)
            {
                staff.DisplayDetails();
            }
        }

        Console.WriteLine("\nDetails of PartTimeStaff members:");
        foreach (var staff in staffList)
        {
            if (staff is PartTimeStaff)
            {
                staff.DisplayDetails();
            }
        }
    }
}