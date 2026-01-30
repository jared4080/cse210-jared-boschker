using System;
using System.Collections;
using Develop02;


class Program
{
    static void Main(string[] args)
    {
        bool has_quit = false;

        while (!has_quit){            
            Console.WriteLine("(1) write\n(2) display\n(3) load\n(4) save\n(5) quit");
            Console.Write("what would you like to do? ");
            string user_choice = Console.ReadLine();

            Journal journal_instance = new Journal();

            switch (user_choice)
            {
                case "1":
                    journal_instance.WriteEntry();
                    break;
                case "2":
                    journal_instance.Display();
                    break;
                case "3":
                    journal_instance.Load();
                    break;
                case "4":
                    journal_instance.Save();
                    break;
                case "5":
                    has_quit = true;
                    Console.WriteLine("okay, see you later! :D");
                    break;
            }
        }
    }
}