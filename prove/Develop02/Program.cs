using System;
using Develop02;


class Program
{
    static void Main(string[] args)
    {
        string prompt = "";
        string text_entry = "";
        Entry journal_entry = new Entry(prompt, text_entry);

        Random _rand = new Random();
        string selected_prompt = JournalData.prompts[_rand.Next(JournalData.prompts.Count)];

        Console.WriteLine(selected_prompt);
    }
}