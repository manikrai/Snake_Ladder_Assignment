using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_ladder
{
    internal class UC3_NoPlay_Ladder_Or_Snake
    {
        public static void No_Play()
        {
           // int Player = 1;
            int position = 0;
            int ladder=0;
            int snake=0;
            Random random = new Random();
            int obj = random.Next(1, 7);
            Console.WriteLine();

            if(obj==position)
            {
                Console.WriteLine("Player stays in same position :" + position);
            }
            else if(obj==ladder)
            {
                ladder = random.Next(1, 7);
            }
            else
            {
                snake = random.Next(1, 7);
            }
           
        }
    }
}
