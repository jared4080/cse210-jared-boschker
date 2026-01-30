using System;
using System.Collections;
using Develop02;


class Program
{
    static void Main(string[] args)
    {
        bool hasQuit = false;

        Console.WriteLine("hey! welcome to home of your new journal! :D");

        while (!hasQuit){            
            Console.WriteLine("\n(1) write\n(2) display\n(3) load\n(4) save\n(5) create save file\n(6) quit");
            Console.Write("what would you like to do? ");
            string userChoice = Console.ReadLine();
            
            Console.WriteLine("");

            Journal journalInstance = new Journal();

            switch (userChoice)
            {
                case "1":
                    journalInstance.WriteEntry();
                    break;
                case "2":
                    journalInstance.Display();
                    break;
                case "3":
                    journalInstance.Load();
                    break;
                case "4":
                    journalInstance.Save();
                    break;
                case "5":
                    journalInstance.CreateTextFile();
                    break;
                case "6":
                    hasQuit = true;
                    Console.WriteLine("okay, see you later! :D");
                    break;
            }
        }
    }
}