using System;

namespace Snake_and_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Player_One_Position = 0;
            Console.WriteLine("Position of Player 1 is at " + Player_One_Position);

            Random random = new Random();
            int rolls = random.Next(1, 6);
            Console.WriteLine("Player 1 rolls the die " + rolls);
        }
    }
}
