// See https://aka.ms/new-console-template for more information

using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;

            //Welcome Message
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC1-EmployeeAttendance
            Random random = new Random();
            int employeeAttendance = random.Next(0, 3); //0 to 2
           //Solving using Switch Case
            switch (employeeAttendance)
            {
                case IS_FULL_TIME:
                    //Code Block
                    Console.WriteLine("Employee is Full-time Present");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    //Code Block
                    Console.WriteLine("Employee is Part-time Present");
                    empHrs = 4;
                    break;
                default:
                    //Code Block
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            //DailyWage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Daily Wage is: " + empWage);
            Console.ReadLine();
        }
    }
}

