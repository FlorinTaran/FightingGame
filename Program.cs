using System;
//using namespace

namespace FightingGame
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int DamagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = DamagePerAttack;

        }



    }


    public class Kata
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string FirstAttacker)
        {
            if (FirstAttacker=fighter1 || FirstAttacker=fighter2)
            {

            string turn = FirstAttacker;
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                if (turn.Equals(fighter1.Name))
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    turn = fighter2.Name;
                }
                else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    turn = fighter1.Name;
                }
            }
            if (fighter1.Health <= 0)
            {
                return fighter2.Name + " is the winner!";
            }
            else
            {
                return fighter1.Name + " is the winner!";
            }

            }

        }
    }
     class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("null");
        }
    }
    
    
}