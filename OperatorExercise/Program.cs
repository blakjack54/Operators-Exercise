using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Basic Arithmetic Operations
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {difference}");
            Console.WriteLine($"{a} * {b} = {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            // Part 2: Calculate the Area of a Circle
            Console.WriteLine("\nEnter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine($"The area of the circle with radius {radius} is {area}");
        }

        // Method to calculate the area of a circle
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
