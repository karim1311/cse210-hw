using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference1 = new Reference("John",3,16);

        Scripture scripture = new Scripture(reference1,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");


        string enter = "";
        int wordsHidden = 0;

        do{
            Console.WriteLine(scripture.GetDisplayText());

            enter = Console.ReadLine();

            if(enter == "")
            {
                Console.WriteLine("you pressed enter");
                wordsHidden++;
                scripture.HideRandomWords(wordsHidden);

            }

            // if(scripture.IsCompletelyHidden() == true)
            // {
            //     enter = "quit";
            // };
            Console.Clear();

        } while (enter != "quit");

        Console.WriteLine(scripture.GetDisplayText());

    }
}