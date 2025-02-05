using System;

namespace UseCaseCode
{
    internal class EmployeeWage
    {
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

    }
}
