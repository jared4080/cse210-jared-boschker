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
            // Console.Write("where would you want to save your files? ");
            string file_name = "save_file.csv";
            string username = Environment.UserName;
            
            string save_file = $"/home/{username}/Develop02/{file_name}";

            foreach (string entry in JournalData.entries)
            {
                File.AppendAllText(save_file, entry + "\n");
            }

            Console.WriteLine("Saved " + JournalData.entries.Count + " entries to " + save_file);
        }

        public void Load()
        {
            // PROMPT user for a file to save to
            // STORE all entreis from that file into a variable
            // REPLACE all entries into the JournalData entries list
            return;
        }
    }
}