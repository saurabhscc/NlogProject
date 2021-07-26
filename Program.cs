using System;

namespace NlogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NLog");
            Addition obj = new Addition();
            Console.WriteLine("Enter 2 numbers");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Addition.add(firstnumber,secondnumber);
        }
    }
}
