using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity / Exceeding requirements:
        // 1. The program only hides words that are still visible (never re-hides already hidden words).
        // 2. A small library of scriptures is used and one is chosen at random each run.

        List<(Reference, string)> library = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16),
             "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),

            (new Reference("Proverbs", 3, 5, 6),
             "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),

            (new Reference("Philippians", 4, 13),
             "I can do all this through him who gives me strength."),

            (new Reference("Psalm", 23, 1),
             "The Lord is my shepherd, I lack nothing."),

            (new Reference("2 Nephi", 2, 25),
             "Adam fell that men might be; and men are, that they might have joy.")
        };

        // Pick a random scripture from the library
        Random random = new Random();
        var selected = library[random.Next(library.Count)];
        Scripture scripture = new Scripture(selected.Item1, selected.Item2);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            // Hide a few words each time (you can change the number)
            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are now hidden. Program ending.");
                break;
            }
        }
    }
}
