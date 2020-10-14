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



               
             Console.WriteLine("Tryck Enter 2 gånger för att starta spelet");


             Random generator = new Random();

             int slag = generator.Next(10, 21);

            string name = Console.ReadLine();

            string boss = Console.ReadLine();

            






            int hp = 100;
             int enemyHp = 100;
             // int boss1hp = 90;
             // int boss2hp = 100;
             // int boss3hp = 120;



                  Console.WriteLine("Välj vilken gubbe du vill spela: \n \n  barbar \n  wizz \n  ork ");

                 while (name != "barbar" && name != "wizz" && name != "ork")
 
              {

                 Console.WriteLine("\n");

                 Console.WriteLine("Svara bara (barbar), (wizz) eller (ork)");

                 Console.WriteLine("\n");

                 name = Console.ReadLine();
              }

             if (name == "barbar" || name == "wizz" || name == "ork")
             {
                Console.WriteLine("Du kommer nu att spela som en " + name +"");
            }
            





            Console.WriteLine("Välj vilken boss du vill möta: \n \n  Boss 1 \n  Boss 2 \n  Boss 3 ");

             while (boss != "Boss 1" && boss != "Boss 2" && boss != "Boss 3")
 
              {

                 Console.WriteLine("\n");

                 Console.WriteLine("Svara bara (Boss 1), (Boss 2) eller (Boss 3)");

                 Console.WriteLine("\n");

                 boss = Console.ReadLine();
              }

             if (boss == "Boss 1" || boss == "Boss 2" || boss == "Boss 3")
             {

                 Console.WriteLine("Du kommer nu att möta " + boss +" ");

                 
             }

             


             Console.WriteLine("\n");


             Console.WriteLine("Du kommer nu att möta " + boss +" ");

             Console.WriteLine("\n");

             Console.Clear();

             while (hp > 0 && enemyHp > 0)
             {

                 Console.Clear();

                 slag = generator.Next(10,21);
                 enemyHp -= slag;
                 Console.WriteLine("" + name + " slår ett slag på " + boss + " just nu har " + enemyHp + " hp", Console.ForegroundColor = ConsoleColor.Green);
                 Console.WriteLine("" + name + " skadade " + slag + " hp", Console.ForegroundColor = ConsoleColor.Red);

                 Console.WriteLine("\n");

                 slag = generator.Next(10,21);
                 hp -= slag;
                 Console.WriteLine("" + boss + " slår ett slag på dig så just nu har " + name + "  "  + hp + " hp ", Console.ForegroundColor = ConsoleColor.Blue);
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
