using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks.Dataflow;


namespace Develop02
{
    public class Journal
    {
        public void WriteEntry()
        {
            Random _rand = new Random();

            string prompt = JournalData.prompts[_rand.Next(JournalData.prompts.Count)];

            Console.WriteLine(prompt);
            string user_entry = Console.ReadLine();

            Entry journal_entry = new Entry(prompt, user_entry);
            JournalData.entries.Add(journal_entry.EntryToString());
        }

        public void Display()
        {
            foreach (string entry in JournalData.entries)
            {
                Console.WriteLine(entry);
            }
        }
    }
}