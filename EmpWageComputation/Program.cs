using System;
namespace EmpWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empRatePerHour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else if (empCheck == isPartTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
