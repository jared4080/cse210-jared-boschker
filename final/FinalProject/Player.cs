using System;


namespace FinalProject
{    
    public class Player
    {
        int moneyAmount = 10;
        string name;


        public Player()
        {
            Console.Write("what's ur name? ");
            name = Console.ReadLine();
            Console.WriteLine($"\nhey {name}! welcome to jared's casino");
        }

        public int GetMoneyAmount()
        {
            return moneyAmount;
        }
    }
}