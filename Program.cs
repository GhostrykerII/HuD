using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuD
{
    internal class Program
    {
        static int Health;
        static int Lives;
        static int HealthChange;
        static int LivesChange;
        static string Name;
        static float Score;
        static float ScoreChange;
        static int Multiplier;
        static int Hit1;
        static int Hit2;
        static int Hit3;



        static void Main(string[] args)
        {


            Health = 100;
            Lives = 3;
            LivesChange = 1;
            Score += ScoreChange;
            Multiplier = 1;
            Hit1 = 10;
            Hit2 = 20;
            Hit3 = 50;
            ScoreChange = 100;

            HUD();


            Console.WriteLine("You Killed an enemy");
            Console.WriteLine();

            KillEnemy();
            HUD();


            Console.WriteLine("You took damage");
            Console.WriteLine("You Killed an enemy");
            Console.WriteLine();

            KillEnemy();
            TakeDamage1();
            HUD();


            Console.WriteLine("Congratulations, you leveled up!");
            Console.WriteLine();

            LevelUp();
            HUD();


            Console.WriteLine("You Killed an enemy");
            Console.WriteLine();

            KillEnemy();
            HUD();


            Console.WriteLine("You took damage");
            Console.WriteLine("You Killed an enemy");
            Console.WriteLine();

            TakeDamage2();
            KillEnemy();
            HUD();



        }
        static void HUD()
        {
            Console.WriteLine("-----------");
            Console.WriteLine(" COOL GAME ");
            Console.WriteLine("-----------");
            Console.WriteLine("");
            Console.WriteLine("Health:" + Health);
            Console.WriteLine("Lives:" + Lives);
            Console.WriteLine("-----------");
            Console.WriteLine("Score:" + Score);
            Console.WriteLine("Multiplier:" + Multiplier);
            Console.WriteLine("-----------");
            Console.WriteLine(Name);
            Console.ReadKey(true);
            Console.Clear();


        }
        static void KillEnemy()
        {
            Score += ScoreChange * Multiplier;
        }
        
        static void TakeDamage1()
        {
            Health -= Hit1;
        }

        static void TakeDamage2()
        {
            Health -= Hit2;
        }

        static void TakeDamage3()
        {
            Health -= Hit3;
        }
        static void LevelUp()
        {
            Multiplier = Multiplier + 1;
        }

    }
}
