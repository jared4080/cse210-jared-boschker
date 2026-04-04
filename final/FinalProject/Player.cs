using System;


namespace FinalProject
{    
    public class Player
    {
        int moneyAmount = 1;
        string name;


        public Player()
        {
            Console.WriteLine("what's ur name?");
            name = Console.ReadLine();
            Console.WriteLine($"\nhi {name}, welcome to jared's casino!! :D");
        }

        public int GetMoneyAmount()
        {
            return moneyAmount;
        }
    }
}