using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userChoice;
            bool loop = true;

            IGeometricShape gShape = new GeometricShape();
            ShapeFactory fact = new ShapeFactory();

            while (loop)
            {
                Console.WriteLine("Input decision:");
                Console.WriteLine("1. Draw Line");
                Console.WriteLine("2. Draw Circle");
                Console.WriteLine("3. Draw Rectangle");
                Console.WriteLine("4. Draw Triangle [Unimplemented]");
                Console.WriteLine("5. Exit");
                userInput = Console.ReadLine();
                userChoice = Convert.ToInt32(userInput);

                if (userChoice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Attempting to draw a Line...");

                    gShape = fact.GetShape(ShapeType.Line);
                    if (gShape != null) gShape.Draw();
                    if (gShape == null) Console.WriteLine("Line could not be drawn.");
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Attempting to draw a Circle...");

                    gShape = fact.GetShape(ShapeType.Circle);
                    if (gShape != null) gShape.Draw();
                    if (gShape == null) Console.WriteLine("Circle could not be drawn.");
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Attempting to draw a Rectangle...");

                    gShape = fact.GetShape(ShapeType.Rectangle);
                    if (gShape != null) gShape.Draw();
                    if (gShape == null) Console.WriteLine("Rectangle could not be drawn.");
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Attempting to draw a Triangle...");

                    gShape = fact.GetShape(ShapeType.Triangle);
                    if (gShape != null) gShape.Draw();
                    if (gShape == null) Console.WriteLine("Triangle could not be drawn.");
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you");
                    loop = false;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
                Console.WriteLine();
            }
        }
    }
}
