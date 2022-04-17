using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_ladder
{
    internal class UC4_Single_Player
    {
        public static int no1, sno1;
        public static int position = 0;
        public static int Dicecount = 0;

        public static void Single_Player()
        {
            Console.WriteLine();
            Console.WriteLine("single player Snake ladder game");

            while (position < 100)
            {
                Random random = new Random();
                no1 = random.Next(1, 7);
                Random random2 = new Random();
                sno1 = random2.Next(1, 4);
                if (sno1 == 1)
                {
                    Dicecount++;
                    Console.WriteLine("No play \n  Dice value: {0} \n", no1);
                }
                else if (sno1 == 2)
                {
                    Console.WriteLine("you got ladder \n Dice value: {0} \n", no1);
                    Dicecount++;
                    position = position + no1;
                    if (position > 100)
                    {
                        Dicecount++;
                        position = position - no1;
                        Console.WriteLine("you got ladder \n Dice value:{0}", no1);
                    }
                    Console.WriteLine("position is: {0}", position);
                    ;
                }
                else
                {
                    Dicecount++;
                    position = position - no1;
                    Console.WriteLine("you got snake option \n Dice value : {0}\n", no1);

                    if (position < 0)
                    {
                        position = 0;
                        Console.WriteLine("\n starting game \n");
                    }
                    Console.WriteLine("you got snake \n your position: {0}\n", position);

                }
            }
            Console.WriteLine("number of times dice roll for winning 100 positon is :{0}", Dicecount);

        }
    }
}