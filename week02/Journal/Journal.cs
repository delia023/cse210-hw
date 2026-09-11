public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile()
{
    Console.Write("Enter the filename: ");
    string filename = Console.ReadLine();

    _entries.Clear();   // remove old entries

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split("|");

        Entry entry = new Entry();
        entry._date = parts[0];
        entry._prompt = parts[1];
        entry._response = parts[2];

        _entries.Add(entry);
    }
}
}