﻿// See https://aka.ms/new-console-template for more information

using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //UC-1 Emplyee Attendence
            Random random = new Random();
            int employeeAttendence = random.Next(0, 2); //0 or 1
            if (employeeAttendence == isPresent)
            {
                Console.WriteLine("Employee is Present");

            }
            else 
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}