using System;
using System.Collections.Generic;
using System.IO;
using library_demo;
class Program
{
    static void Main(string[] args)
    {
       Book book1 = new Book();
       book1.SetAuthor("Smith");
       book1.SetTitle("A Great Book");

       Console.WriteLine(book1.GetBookInfo());


       PictureBook book2 = new PictureBook();
       book2.SetAuthor("Jones");
       book2.SetTitle("A Wonderful Picture Book");
       book2.SetIllustrator("Burton");

       Console.WriteLine(book2.GetBookInfo());
    }

}