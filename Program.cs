using System;

namespace UC_01
    {
        class Program
        {
        static void Main(string[] args) 
            {
                //Constants
                int Present = 1;
                Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == Present) 
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

