using System;

namespace DCIT318Assignment1
{
    public static class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");
            int ticketPrice;

            if (age >= 65 || age <= 12)
                ticketPrice = 7;
            else
                ticketPrice = 10;

            Console.WriteLine("The ticket price is: GHC " + ticketPrice);
        }
    }
}
