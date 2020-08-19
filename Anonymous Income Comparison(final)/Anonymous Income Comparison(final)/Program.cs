using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_final_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program ");
            Console.ReadLine();
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate? ");
            Console.WriteLine("150");
            Console.WriteLine("Hours worked per week? ");
            Console.WriteLine("40");
            Console.ReadLine();
            Console.WriteLine("Person2 ");
            Console.WriteLine("Hourly Rate? ");
            Console.WriteLine("200");
            Console.WriteLine("Hours worked per week? ");
            Console.WriteLine("40");
            Console.ReadLine();

            int person1 = 150 * 40;
            Console.WriteLine("Weekly salary of Person1 ");
            Console.WriteLine(person1);
            Console.ReadLine();
            int person2 = 200 * 40;
            Console.WriteLine("Weekly salary of Person2 ");
            Console.WriteLine(person2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            bool trueOrFalse = person1 > person2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
