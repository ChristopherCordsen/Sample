using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is your age ?
            //Have you ever had a DUI?
            //How many speeding tickets do you have?
            //Use the following qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUI’s.
            //Applicants must not have more than 3 speeding tickets.
            //Print the result of the boolean expression created from the above business rules.
          
            Console.WriteLine("What is your age ?");
            Console.WriteLine(31);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI ?");
            Console.WriteLine("False");
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have ?");   
            Console.WriteLine(2);
            Console.ReadLine();

            int yourAge = 31;
            bool hasDui = false;
            int hasTicket = 2;

            bool insurance = (yourAge >= 15 && hasDui || true && hasTicket <= 3);
           
            Console.WriteLine("Qualified");
            Console.WriteLine(insurance);
            Console.ReadLine();





        }
    }
}
