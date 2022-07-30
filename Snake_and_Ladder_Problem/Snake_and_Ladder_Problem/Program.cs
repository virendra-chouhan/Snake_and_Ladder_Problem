using System;

namespace Snake_and_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;

            int Player_One_Position = 0;
            Console.WriteLine("Position of Player 1 is at " + Player_One_Position);
            while (Player_One_Position < 100)
            {


                Random random = new Random();
                int rolls = random.Next(1, 6);
                Console.WriteLine("Player 1 rolls the die " + rolls);
                int count_of_die_rolls = 0;

                int check = random.Next(1, 4);
                switch (check)
                {
                    case NO_PLAY:
                        Player_One_Position = Player_One_Position + 0;
                        break;
                    case LADDER:
                        
                        if (Player_One_Position < 100)
                        {
                            Player_One_Position = Player_One_Position + rolls;
                            count_of_die_rolls = count_of_die_rolls + 1;
                            Console.WriteLine("Player Position is:" + Player_One_Position);
                        }
                        break;
                    case SNAKE:
                        Player_One_Position = Player_One_Position - rolls;
                        

                    if (Player_One_Position <= 0)
                        {
                            Player_One_Position = 0;
                        }
                        break;
                }

                Console.WriteLine("Player Position is:" + Player_One_Position);
                Console.WriteLine("Count of Die_rolls is:" + count_of_die_rolls);
            }
        }
    }
}
