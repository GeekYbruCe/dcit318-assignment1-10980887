using System;

namespace DCIT318Assignment1
{
    public static class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.Write("Enter side 1 of the triangle: ");
            double side1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter side 2 of the triangle: ");
            double side2 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter side 3 of the triangle: ");
            double side3 = double.Parse(Console.ReadLine() ?? "0");

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
    }
}
