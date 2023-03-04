using System;

namespace UC_02
{
    class Program
    {
           static void Main(string[] args)
        {
            //Constant
            int Full_Time = 1;
            int Emp_Rate_per_Hour = 20;
            //Variables
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == Full_Time) 
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
            empWage = empHours * Emp_Rate_per_Hour;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
