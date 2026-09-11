using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            // you can add more of your own
        };

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

       if (choice == "1")
{
    Random random = new Random();
    int index = random.Next(prompts.Count);
    string prompt = prompts[index];

    Console.WriteLine(prompt);
    Console.Write("> ");
    string response = Console.ReadLine();

    Entry newEntry = new Entry();
    newEntry._date = DateTime.Now.ToShortDateString();
    newEntry._prompt = prompt;
    newEntry._response = response;

    journal.AddEntry(newEntry);
}


else if (choice == "2")
{
    journal.Display();
}


else if (choice == "3")
{
    journal.SaveToFile();
}


else if (choice == "4")
{
    journal.LoadFromFile();
}
else if (choice == "5")


{
    Console.WriteLine("Goodbye!");
}

else
{
    Console.WriteLine("Invalid choice. Please try again.");
}
        }
    }
}