using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");

            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    GradeCalculator.Run();
                    break;
                case 2:
                    TicketPriceCalculator.Run();
                    break;
                case 3:
                    TriangleTypeIdentifier.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
