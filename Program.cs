using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDylan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            int health;
            int lives;
            string gameTitle;
            string gamerTag;
            float percentile;

            score = 0;
            health = 100;
            gamerTag = "gamerdylan";
            gameTitle = "Gaming Game 2";
            percentile = 50f;
            lives = 3;

            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + score + " |" + " Health = " + health + " |" + " Lives = " + lives + " |" + " Rank = " + percentile + "%");

            Console.WriteLine();
            Console.WriteLine(gamerTag + " Slapped a goblin that was harrassing a woman");
            Console.WriteLine(gamerTag + " Scored 10");
            Console.WriteLine(gamerTag + " Scored a date");

            Console.WriteLine();
            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + (score + 10) + " and a date" + " |" + " Health = " + health + " |" + " Lives = " + lives + " |" + " Rank = " + (percentile * 1.22) + "%");

            Console.WriteLine();
            Console.WriteLine(gamerTag + " Makes a wrong move");
            Console.WriteLine(gamerTag + " Gets slapped by date");
            Console.WriteLine(gamerTag + " Lost 10 health");
            Console.WriteLine(gamerTag + " UnScored 5 points");

            Console.WriteLine();
            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + (score + 10 - 5) + " and a broken heart" + " |" + " Health = " + (health - 10) + " |" + " Lives = " + lives + " |" + " Rank = " + (percentile * 1.11) + "%");

            Console.WriteLine();
            Console.WriteLine(gamerTag + " downed a handle of vodka");
            Console.WriteLine(gamerTag + " Lost all score");
            Console.WriteLine(gamerTag + " died");
            
            Console.WriteLine();
            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + (score) + " and a broken liver" + " |" + " Health = " + (health) + " |" + " Lives = " + (lives - 1) + " |" + " Rank = " + (percentile * 0.9) + "%");

            Console.WriteLine();
            Console.WriteLine(gamerTag + " prayed");
            Console.WriteLine(gamerTag + " got gifted score by god");
            Console.WriteLine(gamerTag + " is finally happy");

            Console.WriteLine();
            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + (score + 10) + " and happiness" + " |" + " Health = " + (health) + " |" + " Lives = " + (lives - 1) + " |" + " Rank = " + (percentile * 1.15) + "%");

            Console.WriteLine();
            Console.WriteLine(gamerTag + " walked by a shady man");
            Console.WriteLine(gamerTag + " got stabbed");
            Console.WriteLine(gamerTag + " lost half of everything");

            Console.WriteLine();
            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + ((score + 10) / 2) + " |" + " Health = " + (health / 2) + " |" + " Lives = " + ((lives - 1) / 2) + " |" + " Rank = " + (percentile * 1.15 / 2) + "%");

            Console.WriteLine();
            Console.WriteLine(gamerTag + " bet everything on black");
            Console.WriteLine(gamerTag + " lost");

            Console.WriteLine(gameTitle + "  |  " + gamerTag);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Score = " + (score) + " |" + " Health = " + (health - 100) + " |" + " Lives = " + (lives - 3) + " |" + " Rank = " + (percentile - 50) + "%");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("GAME OVER");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

        }
    }
}
