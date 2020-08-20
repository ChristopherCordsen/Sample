using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 && packageWidth > 25);
            //Console.WriteLine(tooBig);

            //int packageWidth = 10;
            //int packageHeight = 25;
            //bool tooBig = (packageHeight > 25 || packageWidth > 25);
            //Console.WriteLine(tooBig);


            //bool result = (true && (true || false));
            //Console.WriteLine(result);

            //int num1 = 7;
            //int num2 = 12;
            //int num3 = 23;
            //int num4 = 14;
            //int num5 = 8;
            //int num6 = 5;

            //bool result = (num1 > num2 && (num3 == num4 || num5 > num6));
            //Console.WriteLine(result);

            int age = 31;
            bool hasticket = true;
            bool haspassport = true;

            bool canfly = (age >= 18 && hasticket && haspassport);
            Console.WriteLine(canfly);
            Console.ReadLine();

            //Console.WriteLine(true && true && true || false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == false);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);


            Console.WriteLine();
        }
    }
}
