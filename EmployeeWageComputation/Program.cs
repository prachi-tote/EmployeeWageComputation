﻿// See https://aka.ms/new-console-template for more information

using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            int isPresent = 1;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;
            //Welcome Message
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //EmployeeAttendance
            Random random = new Random();
            int employeeAttendance = random.Next(0, 2); //0 or 1
            if (employeeAttendance == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                //empHrs = 0;
            }
            //CalculateDailyWage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Daily Wage is: " + empWage);
            Console.ReadLine();
        }
    }
}