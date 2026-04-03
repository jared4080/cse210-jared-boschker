using System;


namespace FinalProject
{    
    class Player
    {
        int moneyAmount;
        string name;


        public Player()
        {
            Console.WriteLine("what's ur name?");
            name = Console.ReadLine();
            Console.WriteLine($"\nhi {name}, welcome to jared's casino!! :D");
        }
    }
}