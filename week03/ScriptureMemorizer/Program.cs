using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference1 = new Reference("John",3,16);

        Console.WriteLine("We will show the reference.");

        Console.Write(reference1.GetDisplayText());

        Scripture scripture = new Scripture(reference1,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        scripture.GetDisplayText();


    }
}