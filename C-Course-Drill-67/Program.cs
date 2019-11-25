using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {

            //Anonymous Income Comparison Program

            Console.WriteLine("Anonymous Income Comparison Program");
            
            //Person 1
            int hourly1;
            int hours1;

            Console.WriteLine("Person 1");
            
            Console.WriteLine("Hourly Rate?");
            hourly1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            hours1 = Convert.ToInt32(Console.ReadLine());


            //Person 2
            int hourly2;
            int hours2;

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            hourly2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            hours2 = Convert.ToInt32(Console.ReadLine());

            
            int salary1;
            salary1 = hourly1 * hours1;
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine("$" + salary1);

            int salary2;
            salary2 = hourly2 * hours2;
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine("$" + salary2);

            //Comparison

            bool compare = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare);

            Console.ReadLine();

        }
    }
}