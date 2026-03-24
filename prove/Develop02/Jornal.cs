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
            Console.WriteLine("where would you want to save your entries?");
            string saveFile = Console.ReadLine();
            string username = Environment.UserName;

            string filePath = $@"/home/{username}/Documents/cse210-jared-boschker/prove/Develop02";
            if(Directory.Exists(filePath)){
                using (StreamWriter streamWriterInstance = new StreamWriter($"{filePath}/{saveFile}", true))
                    foreach (string line in JournalData.entries)
                    {
                        streamWriterInstance.WriteLine(line);
                    }
            }
            else Console.WriteLine("folder doesn't exist");
            
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
            
            foreach (var entry in JournalData.entries)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine($"loaded {JournalData.entries.Count} entries to the {filePath} file");
        }
    }
}