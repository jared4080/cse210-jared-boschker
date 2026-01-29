using System;
using Develop02;


class Program
{
    static void Main(string[] args)
    {
        // create a menu for the user to select an option
        
        Journal journal = new Journal();
        journal.WriteEntry();
        journal.WriteEntry();
        journal.Display();
    }
}