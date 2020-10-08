using System;

namespace slagskeppet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tryck Enter för att starta spelet");


            Random generator = new Random();

            int hp = generator.Next(10, 21);

            string name = Console.ReadLine();



            Console.WriteLine("Välj ett namn: \n \n a) Mystic \n b) Alpha \n c) Ghost ");

            while (name != "Mystic" && name != "Alpha" && name != "Ghost")

            {


                Console.WriteLine("\n");

                Console.WriteLine("Svara bara (Mystic), (Alpha) eller (Ghost)");

                Console.WriteLine("\n");

                name = Console.ReadLine();
            }

            if (name == "Mystic" || name == "Alpha" || name == "Ghost")
            {

                Console.WriteLine("Din karaktär kommer nu bli kallad för " + name + "");
            }


            Console.WriteLine("Du är just nu på level 1 och kommer få möta level 1 bossen som kallas för The Daedra");


            Console.ReadLine();
        }
    }
}
