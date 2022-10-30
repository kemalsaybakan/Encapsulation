using Encapsulation;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Book Object
            Book bookObj = new Book("Beginner to OOP Programming with C#", -10, "Kemal Saybakan");
            Console.WriteLine(bookObj.getPageNumber());

            // Change Book Class - Page Number Variable
            bookObj.setPageNumber(50);
            Console.WriteLine(bookObj.getPageNumber());
        }
    }
}