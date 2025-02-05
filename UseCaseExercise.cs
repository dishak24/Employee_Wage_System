using System;
using System.Collections.Generic;
using System.Text;

namespace UseCaseCode
{
    internal class UseCaseExercise
    {
       
        public const int wagePerHour = 20;
        public const int fullDayHour = 8;
        public const int partTimeHours = 8;
        public const int maxWorkingDays = 20;
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

            Console.WriteLine("The Daily Employee Wage is : " +dailyWage);
        }

        public void CalculatePartTimeWage()
        {

            int partTimeWage = wagePerHour * partTimeHours;
            Console.WriteLine("Part-Time Employee Daily Wage: " +partTimeWage);
        }

        public void CalculateMonthlyWage()
        {
            int monthlyWage = (wagePerHour * fullDayHour) * maxWorkingDays;
            Console.WriteLine("Total Monthly Wage for " + maxWorkingDays+ " days " +monthlyWage);
        }

        /*public void CalculateWageTillCondition()
        {
            int totalWage = 0;
            int totalHours = 0;
            int totalDays = 0;

        }*/


    }
}
