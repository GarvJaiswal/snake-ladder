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
            int player_pos = 0;
            Random rand = new Random();
            int dice_num = rand.Next(1, 6);
            int option = rand.Next(0, 2);
            switch (option)
            {
                case 0: continue;

                case 1:
                    while (dice_num > 0)
                    {
                        player_pos++;
                    }
                    break;
                case 2:
                    while (dice_num > 0)
                    {
                        player_pos--;
                    }
                    break;
            }
        }
    }
}