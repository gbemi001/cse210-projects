using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1,3);

        DisplayFraction(f1);
        DisplayFraction(f2);
        DisplayFraction(f3);
        DisplayFraction(f4);
    }
    
    static void DisplayFraction(Fraction f)
    {
        Console.WriteLine($"Fraction: {f.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f.GetDecimalValue()}");
        Console.WriteLine();
    }
}