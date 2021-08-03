using System;

namespace DevTest
{
    public class Program
    {
        public static string option;
        static void Main(string[] args)
        {
            StartConsole();
        }

        private static void StartConsole()
        {
            Console.Clear();
            Console.WriteLine("Program to calculate areas");
            Console.WriteLine("");
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");

            ReviewOption();
        }
        private static void GetAreaCircle()
        {
            Console.Clear();

            double r;
            Console.WriteLine("Enter the radius value");

            bool isNumber = double.TryParse(Console.ReadLine(), out r);

            if (isNumber)
            {
                Shape circle = new Circle();
                Console.WriteLine($"The circle area is {circle.GetArea(r, 0)}");
                Continue();
            }
            else
                ParameterNotValid();

        }
        private static void GetAreaRectangle()
        {
            Console.Clear();

            double w;
            Console.WriteLine("Enter the value of the width");
            bool widthIsNumber = double.TryParse(Console.ReadLine(), out w);

            double h;
            Console.WriteLine("Enter the value of the height");
            bool heightIsNumber = double.TryParse(Console.ReadLine(), out h);

            if (widthIsNumber && heightIsNumber)
            {
                Shape rectangle = new Rectangle();
                Console.WriteLine($"The rectangle area is {rectangle.GetArea(w, h)}");
                Continue();
            }
            else
                ParameterNotValid();
        }
        private static void ReviewOption()
        {
            option = Console.ReadLine();

            if (option == "1") GetAreaCircle();
            else if (option == "2") GetAreaRectangle();
            else ParameterNotValid();
        }
        private static void ParameterNotValid()
        {
            Console.WriteLine("Parameter not valid. Please press any key to continue...");
            Console.ReadKey();
            StartConsole();
        }
        private static void Continue()
        {
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            StartConsole();
        }
    }
}
