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
            string userEntry = Console.ReadLine();

            Entry journalEntry = new Entry(prompt, userEntry);
            JournalData.entries.Add(journalEntry.EntryToString());
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
            string fileName = Console.ReadLine();
            string username = Environment.UserName;
            string filePath = $"/home/{username}/Develop02/{fileName}";

            string[] lines = File.ReadAllLines(filePath);
            JournalData.entries = new List<string>(lines);

            Console.WriteLine($"saved {JournalData.entries.Count} entries to the {filePath} file");
        }
    }
}