using System;

namespace DoWhileLoop
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Guess my age?");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 37;

                do
                {
                    switch (number)
                    {
                        case 45:
                            Console.WriteLine("You guessed 45. Try again.");
                            Console.WriteLine("Guess my age?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 49:
                            Console.WriteLine("You guessed 49. Try again.");
                            Console.WriteLine("Guess my age?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 32:
                            Console.WriteLine("You guessed 32. Try again.");
                            Console.WriteLine("Guess my age?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 37:
                            Console.WriteLine("You are correct, I'm 37!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("Nope, wrong.");
                            Console.WriteLine("Guess my age?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);

                Console.Read();
            }
        
    }
}