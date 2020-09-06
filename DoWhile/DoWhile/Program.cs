using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How tall are you in inches? ");
            int height = Convert.ToInt32(Console.ReadLine());

            string result = height >= 67 ? "You're tall! " : "sup shorty!";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
