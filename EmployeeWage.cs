using System;

namespace UseCaseCode
{
    internal class EmployeeWage
    {
        public const int wagePerHour = 20;
        public const int fullDayHour = 8;
        public void AttendanceChecker()
        {
            Random r = new Random();
            int attendance = r.Next(0, 2);
            if (attendance == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        public void CalculateDailyWage()
        {

            int dailyWage = wagePerHour * fullDayHour;

            Console.WriteLine("The Daily Employee Wage is : " + dailyWage);
        }

    }
}
