using System;

namespace SelectionStatementsPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //evaluate to a string

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("That is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("I stay away from science, it's so hard!");
                    break;
                case "english":
                    Console.WriteLine("English is an interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I have never taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}
