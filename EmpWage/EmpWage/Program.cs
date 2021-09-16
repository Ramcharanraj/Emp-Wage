using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int per_Hour_Wage = 100;
            int HOURS_WORKED = 8;
            int PART_TIME_HOURS = 4;
            int DAILYWAGES = 0;
            Random rand = new Random();
            int WorkStatus = rand.Next(0, 3);

            switch (WorkStatus)
            {
                case 0:
                    Console.WriteLine("Empoyee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Empoyee is Present");
                    DAILYWAGES = per_Hour_Wage * HOURS_WORKED;
                    break;
                case 2:
                    Console.WriteLine("Employee is working is part time");
                    DAILYWAGES = per_Hour_Wage * PART_TIME_HOURS;
                    break;

                default:
                    Console.WriteLine("employee is out of range");
                    break;
            }

            Console.WriteLine("The Employee Wage is " + DAILYWAGES);
        }
    }
}