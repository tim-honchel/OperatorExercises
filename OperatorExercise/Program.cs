using System;

namespace OperatorExercise
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCISE 1");
            Console.WriteLine("We will be performing several mathematical computations.");

            Console.WriteLine();
            Console.WriteLine("Please enter the first of two integers:");
            int intA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please enter the second of two integers:");
            int intB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Add(intA, intB);
            Subtract(intA, intB);
            Multiply(intA, intB);
            Divide(intA, intB);

            Console.WriteLine();
            Console.WriteLine("EXERCISE 2");
            Console.WriteLine("We will be calculating the area of a circle.");
            Console.WriteLine();
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Area(radius);


        }

        public static void Add(int intA, int intB)
        {
            Console.WriteLine(intA + "+" + intB + " is " + (intA + intB));

        }

        public static void Subtract(int intA, int intB)
        {
            Console.WriteLine(intA + "-" + intB + " is " + (intA - intB));

        }

        public static void Multiply(int intA, int intB)
        {
            Console.WriteLine(intA + "x" + intB + " is " + (intA * intB));
        }

        public static void Divide(int intA, int intB)
        {
            int quotient = intA / intB;
            int remainder = intA % intB;
            Console.WriteLine(intA + "/" + intB + " is " + quotient + " remainder " + remainder);
        }

        public static void Area(double radius)
        {
            Console.WriteLine("The area of a circle with radius of " + radius + " is " + (3.14 * radius * radius));
        }
    }
}
