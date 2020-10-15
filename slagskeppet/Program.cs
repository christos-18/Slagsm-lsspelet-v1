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
                    Console.Clear();
                    Console.WriteLine("Ogiltigt svar! \n");

                }


            }
        }





        static void RunGame()
        {




            Console.WriteLine("Tryck Enter en gång för att starta spelet");


            Random generator = new Random();

            int slag = generator.Next(10, 21);

            string name = "";

            string boss = "";

            Console.ReadLine();








            int hp = 100;
            int enemyHp = 100;




            Console.WriteLine("Välj vilken gubbe du vill spela: \n \n  Garen \n  Ashe \n  Darius ");

            while (name != "Garen" && name != "Ashe" && name != "Darius")

            {

                Console.WriteLine("\n");

                Console.WriteLine("Svara bara (Garen), (Ashe) eller (Darius)");

                Console.WriteLine("\n");

                name = Console.ReadLine();
            }

            if (name == "Garen") // beroende på vilken gubbe man väler så har man olika fördelar (riggat)
            {
                slag = generator.Next(18, 31);
                hp = 110;
            }

            else if (name == "Ashe")
            {
                slag = generator.Next(15, 27);
            }

            else if (name == "Darius")
            {
                hp = 120;
            }

            Console.Clear();


            Console.WriteLine("Du kommer nu att spela som " + name + "");


            Console.WriteLine("\n");







            Console.WriteLine("Välj vilken boss du vill möta: \n \nAlla bossar är olika svåra \n \n  Boss 1 \n  Boss 2 \n  Boss 3 \n ");


            while (boss != "Boss 1" && boss != "Boss 2" && boss != "Boss 3")

            {

                Console.WriteLine("\n");


                Console.WriteLine("Svara bara (Boss 1), (Boss 2) eller (Boss 3)");

                Console.WriteLine("\n");

                boss = Console.ReadLine();
            }

            if (boss == "Boss 1") //beroende på vilken boss man möter så är det olika svårt
            {
                enemyHp = 90;
            }

            else if (boss == "Boss 2")
            {
                enemyHp = 100;
            }

            else if (boss == "Boss 3")
            {
                enemyHp = 130;
            }




            Console.WriteLine("\n");


            while (hp > 0 && enemyHp > 0)
            {
                Console.Clear();



                slag = generator.Next(10, 21);
                enemyHp -= slag;
                Console.WriteLine($"{name} slår ett slag på {boss} så just nu har {boss} {enemyHp} hp", Console.ForegroundColor = ConsoleColor.Green);
                Console.WriteLine("" + name + " skadade " + slag + " hp", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine($"{boss} hp = {enemyHp}", Console.ForegroundColor = ConsoleColor.Yellow);

                Console.WriteLine("\n");

                slag = generator.Next(10, 21);
                hp -= slag;
                Console.WriteLine($"{boss} slår ett slag på dig så just nu har {name} {hp} hp", Console.ForegroundColor = ConsoleColor.Blue);
                Console.WriteLine("Bossen skadade dig med " + slag + " hp", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine($"{name} hp = {hp}\n", Console.ForegroundColor = ConsoleColor.Yellow);



                Console.WriteLine("\nTryck Enter för att slå ett slag \n", Console.ForegroundColor = ConsoleColor.White);

                if (enemyHp < 0)
                {
                    Console.WriteLine("Grattis, du vann!");
                    Console.WriteLine("\nTryck Enter för att gå vidare");

                }

                else if (hp < 0)
                {
                    Console.WriteLine("Du förlorade!");
                    Console.WriteLine("\nTryck Enter för att gå vidare");
                }

                Console.WriteLine("\n ");

                Console.ReadLine();



            }


























        }


    }


}





