using System;

namespace Snake_And_Ladder_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            int rollDie1_p1 = 0;
            int finish = 100;
            while (player1 < finish)
            {
            Random obj = new Random();
                int randomDie1 = obj.Next(1, 7);
                rollDie1_p1++;
            string[] names = new string[] { "no play", "ladder", "snake" };
                Random rand = new Random();
                int randomOption1 = rand.Next(names.Length);

                if (names[randomOption1] == "ladder")
                {
                    player1 += randomDie1;
                    if (player1 > 100)
                    {
                        player1 -= randomDie1;
                    }
                }
                else if (names[randomOption1] == "snake")
                {
                    player1 -= randomDie1;
                    if (player1 < 0)
                    {
                        player1 += randomDie1;
                    }
                }
                
            }
        }
    }
}
