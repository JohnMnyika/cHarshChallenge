using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string regXp = "[a-z]+$";

            string fruits = "apples";

            string randomchar = "abc123xyz";

            while (regXp != "[a-z]+$" && regXp.Contains("z")) 
            {
                    Console.Write("Enter a regular expression: ");
                    
                    regXp = Console.ReadLine();

                Console.Write("Find a fruit I like: ");
                fruits = Console.ReadLine();

            }
            if (fruits == "apples")
            {
                Console.Write("You got it");
            }
            else
            


            if (regXp == "[a-z]+$" && regXp.Contains("z"))
            {

                Console.Write("Enter a random character");
            }


            if (randomchar != "abc123xyz")
            {
                Console.WriteLine("Try again");
            }

            Console.WriteLine("");
        }
    }
}
