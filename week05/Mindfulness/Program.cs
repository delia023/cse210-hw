using System;
using System.Threading;

/*
 * Creativity / Exceeding Requirements:
 * - Keeps a simple in-memory log of how many times each activity was performed
 *   during the current session.
 * - Displays a clean Session Summary when the user chooses Quit.
 * This is explained here as required by the assignment.
 */

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($"  Breathing activities completed: {breathingCount}");
                Console.WriteLine($"  Reflection activities completed: {reflectionCount}");
                Console.WriteLine($"  Listing activities completed: {listingCount}");
                Console.WriteLine();
                Console.WriteLine("Thank you for practicing mindfulness. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(1500);
            }
        }
    }
}