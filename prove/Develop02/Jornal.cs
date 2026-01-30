using System;
using System.IO;
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

            Console.Write(prompt);
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

        public void Save()
        {
            Console.Write("where would you like to save your entries?");
            string file_name = Console.ReadLine();
            string username = Environment.UserName;
            string file_path = $"/home/{username}/Develop02/{file_name}";

            foreach (string entry in JournalData.entries)
            {
                File.AppendAllText(file_path, entry + Environment.NewLine);
            }

            Console.WriteLine($"saved {JournalData.entries.Count} entries to the {file_path} file");
        }


        public void Load()
        {
            Console.Write("where would you like to load your entries from?");
            string file_name = Console.ReadLine();
            string username = Environment.UserName;
            string file_path = $"/home/{username}/Develop02/{file_name}";

            string[] lines = File.ReadAllLines(file_path);
            JournalData.entries = new List<string>(lines);

            Console.WriteLine($"saved {JournalData.entries.Count} entries to the {file_path} file");
        }
    }
}