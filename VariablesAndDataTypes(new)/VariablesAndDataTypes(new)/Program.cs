using System;

namespace VariablesAndDataTypes_new_
{
    class Program
    {
        static void Main(string[] args)
        {
            ////This is a simple program     (ctrl KC is comments it and to uncomment is ctrl KU)
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine(); //Casting
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.Read();

            //Console.WriteLine("What is your favorite number?"); //Math 
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            //char randomLetter = "X"; 
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.234567;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Christopher";

            int currentAge = 37;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
