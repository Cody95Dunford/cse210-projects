using System;
using System.IO;

public class Journal{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        Entries.Add(newEntry);
    }
    public void DisplayAll(){
        foreach (var entry in Entries){
            entry.Display();
        }
    }
    public void SaveToFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in Entries){
                outputFile.WriteLine($"{entry.dateText},{entry.prompt},{entry.text}");
            }
        }
    }    
    public void LoadFromFile(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);
        Entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry loadJournal = new Entry();
            loadJournal.dateText = parts[0];
            loadJournal.prompt = parts[1];
            loadJournal.text = parts[2];
            Entries.Add(loadJournal);
        }
    }
}