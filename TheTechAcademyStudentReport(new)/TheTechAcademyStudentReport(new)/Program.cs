using System;

namespace TheTechAcademyStudentReport_new_
{
    class Program
    {
        private const bool V = true;

        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Student Report");
            Console.ReadLine();


            // Questions to ask
            //What course are you on?
            //What page number?
            //Do you need help with anything? Please answer “true” or “false”.
            //Were there any positive experiences you’d like to share? Please give specifics.
            //Is there any other feedback you’d like to provide? Please be specific.
            //How many hours did you study today?
            //After print “Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” 

            Console.WriteLine("What course are on?");
            string course = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer True or False!");
            string helpStatus = Console.ReadLine();
            //bool needHelp = V;
            //var helpStatus = Convert.ToString(value: V);
            //Console.WriteLine(helpStatus);
            //Console.ReadLine();

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();



            //Answers to Questions 
            Console.WriteLine("Your Answers!");
            Console.WriteLine("Your course is: " + course); 
            Console.WriteLine("Your page number is: " + pageNumber);
            Console.WriteLine("Help true or false: " + helpStatus);
            Console.WriteLine("Your positive experiences are: " + positiveExperiences);
            Console.WriteLine("Your feedback is: " + feedback);
            Console.WriteLine("Your hours worked are: " + hoursStudy);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();

        }
    }
}
