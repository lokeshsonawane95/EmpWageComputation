using System;
namespace EmpWageProblem
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        public static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < numOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
