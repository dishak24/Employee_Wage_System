using System;

namespace UseCaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wages System !");

            while (true)
            {
                EmployeeWage employeeWage = new EmployeeWage(); 
                Console.WriteLine("1: Attendance Checking");
                Console.WriteLine("2: Calculate Employees Daily Wages");
                Console.WriteLine("3: Calculate Part time Employee Wages");
                Console.WriteLine("4: Calculate wages for a Month");
                Console.WriteLine("5: calculate wage till a condition of total working hours or days is reached for a month");
                Console.WriteLine("0: Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your Choice :");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        employeeWage.AttendanceChecker();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;

                }
    }
}
