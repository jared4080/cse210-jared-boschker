using System;


namespace FinalProject
{    
    public class Player
    {
        int _moneyAmount = 20;
        string _name;


        public Player()
        {
            Console.Write("what's ur name? ");
            _name = Console.ReadLine();
            Console.WriteLine($"\nhey {_name}! welcome to jared's casino");
        }

        public void ChangeCurrency(int moneyAmount)
        {
            _moneyAmount += moneyAmount;
            Console.WriteLine($"now you have ${_moneyAmount}");
        }

        public int GetCurrency()
        {
            return _moneyAmount;
        }

        public int GetMoneyAmount()
        {
            return _moneyAmount;
        }
    }
}