using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {


            int continueplaying = 1;

            RunGame();

            while (continueplaying == 1)
            {

                Console.WriteLine("Vill du spela igen, ja eller nej?", Console.ForegroundColor = ConsoleColor.White);


                string answer = Console.ReadLine();
                
                if (answer.ToLower() == "ja")
                {
                    Console.Clear();

                    RunGame();
                }
                else if (answer.ToLower() == "nej")
                {
                    continueplaying = 0;
                }
                else
                {
                    Console.WriteLine("Ogiltigt svar! \n");

                    Console.Clear();
                }


            }
        }



            

         static void RunGame()
            {



               
             Console.WriteLine("Tryck Enter för att starta spelet");


             Random generator = new Random();

             int slag = generator.Next(10, 21);

             string name = Console.ReadLine();

             int hp = 100;
             int enemyHp = 100;


             Console.WriteLine("Välj ett namn: \n \n  Mystic \n  Alpha \n  Ghost ");

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

             Console.WriteLine("\n");


             Console.WriteLine("Du är just nu på level 1 och kommer få möta level 1 bossen som kallas för The Daedra");

             Console.WriteLine("\n");

             Console.Clear();

             while (hp > 0 && enemyHp > 0)
             {

                 Console.Clear();

                 slag = generator.Next(10,21);
                 enemyHp -= slag;
                 Console.WriteLine("" + name + " slår ett slag på bossen the Daedra så just nu har Bossen " + enemyHp + " hp", Console.ForegroundColor = ConsoleColor.Green);
                 Console.WriteLine("" + name + " skadade " + slag + " hp", Console.ForegroundColor = ConsoleColor.Red);

                 Console.WriteLine("\n");

                 slag = generator.Next(10,21);
                 hp -= slag;
                 Console.WriteLine("Bossen the Daedra slår ett slag på " + name + " så just nu har " + name + " "  + hp + " hp ", Console.ForegroundColor = ConsoleColor.Blue);
                 Console.WriteLine("Bossen skadade dig med " + slag + " hp \n", Console.ForegroundColor = ConsoleColor.Red);

                 Console.WriteLine("Tryck Enter för att slå ett slag \n", Console.ForegroundColor = ConsoleColor.White);


                 Console.ReadLine();

             }

             if (enemyHp < 0)
             {
                Console.WriteLine("Grattis, du vann!");

             }

             else if (hp < 0)
             {
                 Console.WriteLine("Du förlorade!");
             }

             Console.WriteLine("\n");
            

            
        }
            




    }
}
