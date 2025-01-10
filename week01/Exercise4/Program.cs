using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // Create new list of numbers
        List<int> numbers = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (number!=0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if(number!=0)
            {
                numbers.Add(number);
            }
        } 

        int sum = 0;
        // Sums every number in the list
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Part 2: Compute the average
        // Notice that we first cast the sum variable to be a float. Otherwise, because
        // both the sum and the count are integers, the computer will do integer division
        // and I will not get a decimal value (even though it puts the result into a float variable).

        // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.
        float average = ((float)sum / numbers.Count);
        

        // Gets the largest number in the list
        int largest = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        // Prints results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}