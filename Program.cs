using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player_pos1 = 0;
            int player_pos2 = 0;
            //int count = 0;
            int i = 1;
            Random rand = new Random();
            while (player_pos1 <= 100 || player_pos2 <= 100)
            {

                int dice_num = rand.Next(1, 7);
                //count++;
                int option = rand.Next(1, 4);
                switch (option)
                {
                    case 1: //no play
                        if (i == 1)
                        {
                            Console.WriteLine("No play:\nPosition of player1 is " + player_pos1);
                            i = 2;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No play:\nPosition of player2 is " + player_pos2);
                            i = 1;
                            break;
                        }

                    case 2:
                        if (i == 1)
                        {
                            //int newPos1 = player_pos1 + dice_num;
                            if (player_pos1 + dice_num <= 100)
                            {
                                player_pos1 += dice_num;
                                Console.WriteLine("After ladder:\nPosition of player1 is " + player_pos1);
                            }
                            else
                            {
                                player_pos1 = player_pos1;
                            }
                            i = 1;
                        }
                        else
                        {
                            if (player_pos2 + dice_num <= 100)
                            {
                                player_pos2 += dice_num;
                                Console.WriteLine("After ladder:\nPosition of player2 is " + player_pos2);
                            }
                            else
                            {
                                player_pos2 = player_pos2;
                            }
                            i = 2;
                        }
                        break;
                    case 3:
                        if (i == 1)
                        {
                           
                            Console.WriteLine("After snake:\nPosition is of player1 is " + player_pos1);
                            i = 2;
                            player_pos1 -= dice_num;
                            if (player_pos1 - dice_num < 0)
                            {
                                player_pos1 = 0;
                            }
                        }
                        else
                        {
                            
                            Console.WriteLine("After snake:\nPosition is of player2 is " + player_pos2);
                            i = 1;
                            player_pos2 -= dice_num;
                            if (player_pos2 - dice_num < 0)
                            {
                                player_pos2 = 0;
                            }
                        }
                        break;
                }
                if (player_pos1 == 100)
                {
                    Console.WriteLine("Player1 won");
                    break;
                }
                if (player_pos2 == 100)
                {
                    Console.WriteLine("Player2 won");
                    break;
                }

            }


            //Console.WriteLine("Player Position : " + player_pos);
            //Console.WriteLine("Dice was rolled " + count + " times");

            Console.ReadLine();
        }
    }
}
