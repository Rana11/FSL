using System;

namespace FSLCodeExercise.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("FSL Code Exercise v1.0");
            Console.WriteLine();
            Console.WriteLine("Calculates and prints information for a user-supplied shape and width");
            Console.WriteLine("---------------------------------------------------------------------");


            Console.WriteLine("Do you want a square (1), circle (2), or equilateral triangle (3): ");
            int type = int.Parse(Console.ReadLine());

            if (IsValidInput(type))
            {
                Console.WriteLine("Enter the shape's primary dimension (width, radius, or base): ");
                double width = double.Parse(Console.ReadLine());

                Shape s = ShapeFactory.CreateInstance((ShapeType)type, width);

                Console.WriteLine();
                Console.WriteLine("Shape properties:");
                Console.WriteLine("\tWidth: " + s.Width);
                Console.WriteLine("\tArea: " + s.Area);
            }
            else
            {
                Console.WriteLine("Unknown shape type encountered: " + type);
            }
           
        }

        private static bool IsValidInput(int type)
        {
            return Enum.IsDefined(typeof(ShapeType), type);
        }
    }
}


/* Exercise 1:
 * 1) Identify the most offensive code "smell":
 * Lack of inheritance 
 * Violating OCP

 * 2) Identify potential problems that could be encountered in developing and/or maintaining a system that uses the code as it is written
 * Very hard to maintain or extend
 */


/* Exercise 3:
 * 1) Describe why the refactored code is better than the previous code:
 * it is structured, cleaner, does not violate the OCP, easier to maintain, 
 * Follow some design patterns ex. Factory Pattern
 * 
 * 2) Describe what you would do if you had longer than 2 hours to complete these exercises.
 * I will write some unit tests
 */