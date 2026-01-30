using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics.CodeAnalysis;


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
            string fileName = Console.ReadLine();
            string username = Environment.UserName;
            string filePath = $"/home/{username}/Develop02/{fileName}";

            File.WriteAllLines(filePath, JournalData.entries);

            Console.WriteLine($"saved {JournalData.entries.Count} entries to the {filePath} file");
        }

        public void CreateTextFile()
        {
            Console.WriteLine("what would you like the new save file to be called? ");
            string newFile = Console.ReadLine();
            newFile = newFile + ".txt";

            string projectFolder = Path.Combine(Directory.GetCurrentDirectory(), "../../..");
            string fullPath = Path.Combine(projectFolder, newFile);
            
            File.Create(fullPath).Close();
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