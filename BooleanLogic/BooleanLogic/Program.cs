using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

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

            //int age = 31;
            //bool hasticket = true;
            //bool haspassport = true;

            //bool canfly = (age >= 18 && hasticket && haspassport);
            //Console.WriteLine(canfly);
            //Console.ReadLine();

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

            //if (true) ;
            //{
            //    Console.WriteLine("Hello!");
            //}


            //if (1 == 1);
            //{
            //    Console.WriteLine("1 equals 1!");
            //}
            //else
            //{
            //    Console.WriteLine("1 does not equal 1");
            //}

            //string name = "Brett";

            //if (name == "Jesse") 
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}

            //string name = "Adam";

            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");

            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is not Jessee");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Jesse. your name is not Brett.");
            ////}

            //string name = "Erik";

            //if (name == "Jesse") 
            //{
            //    Console.WriteLine("Your name is Jessee");
            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is not Jessee");
            //}
            //else if (name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam");

            //    string name = "Adam";

            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine("Your name is Jesse");
            //    }
            //    if (name == "Brett")
            //    {
            //        Console.WriteLine("Your name is not Jesse");
            //    }
            //    if (name == "Adam")
            //    {
            //        Console.WriteLine("Your name is Adam");
            //    }
            //    string name = "Adam";

            //    if (name != "Jesse")
            //    {
            //        Console.WriteLine("your name is not Jesse");
            //    }
            //    if (1 != 2)
            //    {
            //        Console.WriteLine("All is right with the universe.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("We live in a bizarro wolrd.");
            //    }

            //    int num1 = 12;
            //    int num2 = 14;
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine("The first number is larger.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The second number is larger.");
            //    }

            //    int age = 19;

            //    if (age > 21)
            //    {
            //        Console.WriteLine("No you may not purchase that bottle of wine.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That will be $23.75");
            //    }

            //    int age = 20;

            //    if (age <= 20)
            //    {
            //        Console.WriteLine("No you may not purchase that bottle of wine.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("There you go!");
            //    }

            //    int age = 20;

            //    if (age >=25)
            //    {
            //        Console.WriteLine("Yes you may rent a car from us.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No you may not rent a car from us.");
            //    }
            ////}

            //int num1 = 7;
            //int num2 = 18;
            //int num3 = 12;
            //if (num2 > num1 && num3 <)
            //{
            //    Console.WriteLine("The second number is larger than the others.");
            //}

            //int num1 = 7;

            //if (true && true && true && true && num1 == 20)
            //{
            //    Console.WriteLine("Everything was true!");
            //}
            //else
            //{
            //    Console.WriteLine("there was a false somewhere!");
            //}

            //int packageWeight = 50;
            //int packageLenght = 25;
            //if (packageWeight > 40 && packageLenght > 20)
            //    Console.WriteLine("this package is too big to ship.");

            //int num1 = 7;

            //if (num1 < 7 || num1 ==12)
            //{
            //    Console.WriteLine("At lease one value is true.");
            //}
            //if (num1 == 12 || num1 == 18)
            //{
            //    Console.WriteLine("At lease one value is true.");
            //}
            //else
            //{
            //    Console.WriteLine("No value is true.");
            //}

            //if (num1 == 12 || num1 ==18 || num1 == 20 || num1 ==7)
            //{
            //    Console.WriteLine("Something is true.");
            //}

            //string role = "admin";
            //if (role == "admin" || role == "administrator")
            //{
            //    Console.WriteLine("You may have access to the entire software system.");
            //}

            //int num1 = 7;
            //if (num1 < 18 && ((num1 == 7) || num1 == 2) && ((num1 == 8 && num1 > 8 && num1 > 20) || (num1 < 20 && num1 > 2)))
            //{
            //    Console.WriteLine("Wow, that was confusing.");
            //}

            //int num1 = 7;
            //int num2 = 12;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            //Console.WriteLine(result);

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temerature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature. ");
            //}
            //Console.WriteLine();

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();
            //int roomTemperature = 70;

            //Console.WriteLine("Hi what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", What is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature. ");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhh... something went wrong");
            //}
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number? ");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 13 ? "You have an awesome favorite number. " : " Your number sucks";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
