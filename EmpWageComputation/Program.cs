﻿using System;
namespace EmpWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int isPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is not Present");
            }
        }
    }
}
