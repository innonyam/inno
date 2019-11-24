using System;

namespace salarycalapp
{
    class Program
    {
        static void Main(string[] args)
        {
         var Employee1=new SalaryCalculator( 1, "james", "section");
                    Console.WriteLine(" your net salary is: " + SalaryCalculator.CalculateSalary(500000));
                    Console.WriteLine(" your Hourly salary:"+SalaryCalculator.CalculateHourly(12, 34));
                    Console.WriteLine("your Hourly salary:"+ SalaryCalculator.CalculateDaily(12));
        }
    }
}