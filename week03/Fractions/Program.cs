using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");


        Fraction f =  new Fraction();
        Console.WriteLine("We are using the 1st constructor.");
        Console.WriteLine(f.GetFractionString());

        Fraction f2 = new Fraction(6);
        Console.WriteLine("We are now using the 2nd constructor.");
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(6,7);
        Console.WriteLine("We are now using the 3rd constructor.");
        Console.WriteLine(f3.GetFractionString());



        // 
        
        Console.WriteLine($"We will show the top value {f3.getTop()}");
        Console.WriteLine($"We will now set the top value to 3 ");
        f3.setTop(3);
        Console.WriteLine($"The top value is now {f3.getTop()}");

        // Verify that you can call each constructor and that you can retrieve and display the different representations for a
        // few different fractions. For example, you could try:
        // 1
        // 5
        // Sample Output
        // 1/1
        // 1
        // 5/1
        // 5

        Fraction ff = new Fraction(1);
        Console.WriteLine(ff.GetFractionString());
        Console.WriteLine(ff.GetDecimalValue());

        Fraction ff2 = new Fraction(5);
        Console.WriteLine(ff2.GetFractionString());
        Console.WriteLine(ff2.GetDecimalValue());

        Fraction ff3 = new Fraction(3,4);
        Console.WriteLine(ff3.GetFractionString());
        Console.WriteLine(ff3.GetDecimalValue());

        Fraction ff4 = new Fraction(1,3);
        Console.WriteLine(ff4.GetFractionString());
        Console.WriteLine(ff4.GetDecimalValue());
    }
}