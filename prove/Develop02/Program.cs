using System;
using System.Collections;
using Develop02;


class Program
{
    static void Main(string[] args)
    {
        bool has_quit = false;

        Console.WriteLine("hey! welcome to home of your new journal! :D");

        while (!has_quit){            
            Console.WriteLine("\n(1) write\n(2) display\n(3) load\n(4) save\n(5) create save file\n(6) quit");
            Console.Write("what would you like to do? ");
            string user_choice = Console.ReadLine();
            
            Console.WriteLine("");

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
                    journal_instance.CreateTextFile();
                    break;
                case "6":
                    has_quit = true;
                    Console.WriteLine("okay, see you later! :D");
                    break;
            }
        }
    }
}