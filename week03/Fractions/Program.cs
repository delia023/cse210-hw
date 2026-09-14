using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the three constructors
        Fraction f1 = new Fraction();          // 1/1
        Fraction f2 = new Fraction(5);         // 5/1
        Fraction f3 = new Fraction(3, 4);      // 3/4
        Fraction f4 = new Fraction(1, 3);      // 1/3

        // Display results (matches the sample output)
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Optional: demonstrate getters/setters
        Console.WriteLine();
        f3.SetTop(7);
        f3.SetBottom(8);
        Console.WriteLine($"After setters: {f3.GetFractionString()} = {f3.GetDecimalValue()}");
    }
}