using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_ladder
{
    internal class UC5_Two_Player
    {
        public static int no1, no2, no3, no4, sno1, sno2, diff3;
        public static int position = 0, position2 = 0;
        public static int Dicecount = 0, Dicecount2 = 0;

        public static void two_player()
        {
            while (position < 100 && position2 < 100)
            {
                Random random = new Random();
                no1 = random.Next(1, 7);
                Random random2 = new Random();
                no2 = random.Next(1, 7);
                Random random1 = new Random();
                sno1 = random1.Next(1, 4);
                Random random3 = new Random();
                sno2 = random3.Next(1, 4);

                if (sno1 == 1)
                {
                    Dicecount++;
                    Console.WriteLine("Player one Has no Option \n Player one Dice value: {0} \n Player one Position{1}\n", no1, position);
                }
                else if (sno2 == 2)
                {
                    position = position + no1;

                    if (position > 100)
                    {
                        position = position - no1;
                    }
                    Console.WriteLine("Player one got ladder option \n player one Dice value: {0} \n player one position : {1}", no1, position);

                    Console.WriteLine("Play again Single player got ladder");
                    Random obj
                        = new Random();
                    no3 = obj.Next(1, 7);
                    position = position + no3;
                    Console.WriteLine("player one second chance Dice value: {0} ", no3);
                    Dicecount++;
                    Dicecount++;
                    if(position2 > 100)
                    {
                        position = position - no3;
                        Console.WriteLine("player one got ladder \n player one Dice value: {0} ", no3);
                    }
                    Console.WriteLine("player one position: {0} \n ", position);


                }
                else
                {
                    Dicecount++;
                    position = position + no1;
                    if(position<0)
                    {
                        position=0;
                        Console.WriteLine("Again game starts for player one");
                    }
                    Console.WriteLine("snake bite player one position: {0} ",position);
                    Console.WriteLine("player one Dice value: {0}\n",no1);
                }
                if (sno2 == 1)
                {
                    Dicecount2++;
                    Console.WriteLine("player two got no play option \n player two Dice value: {0} \n", no1);

                }
                else if (sno2 == 2)
                {
                    Dicecount2++;
                    position2 = position2 + no2;
                    if (position2 > 100)
                    {
                        position2 = position2 - no2;
                    }
                    Console.WriteLine("player two got ladder option \n player two Dice value: {0} \n player two position: {1}", no2);
                    Console.WriteLine("playing Again player two got ladder");
                    Random obj2 = new Random();
                    no4 = obj2.Next(1, 7);
                    position2 = position2 + no4;
                    Console.WriteLine("player two second chance Dice value: {0}", no4);
                    Dicecount2++;
                    if (position2 > 100)
                    {
                        position2 = position2 - no4;
                        Console.WriteLine("player two got ladder\n player two Dice value: {0}", no2);
                    }
                        Console.WriteLine("player two position: {0}\n", position2);
                     else
                      { 
                        Dicecount2++;
                        position2=position2 + no2;
                        Console.WriteLine("\nsnake bite player two \n player two Dice value: {0}",no2);
                        if(position2 < 0)
                        {
                            position2=0;
                            Console.WriteLine("startin game again for player two");

                        }
                        Console.WriteLine("player two position: {0} \n", position2);
                       }


                }
                if (position>position2)
                {
                    diff3 = position - position2;
                    Console.WriteLine("player one won to player two by " +diff3);
                }
                else
                {
                    diff3 = position2 - position;
                    Console.WriteLine("player two won to player one by " + diff3);
                }
                Console.WriteLine("number of times dice roll for player two: {0}", Dicecount2);
                Console.WriteLine("number of times dice roll for player one: {0}", Dicecount);
            }

        }
    }
}