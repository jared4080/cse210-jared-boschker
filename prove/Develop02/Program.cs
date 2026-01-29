using System;
using Develop02;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.WriteEntry();
        journal.Display();
    }
}