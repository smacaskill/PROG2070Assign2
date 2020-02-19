using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Triangle verification program
// Sandy MacAskill
// Feb 2020
namespace PROG2070Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice;

            // Main menu, can only exit through program
            while (1 == 1)
            {
                    Console.WriteLine("\nPlease select one of the following options: ");
                    Console.WriteLine("1. Enter Triangle Dimensions");
                    Console.WriteLine("2. Exit\n");
                    menuChoice = Console.ReadLine();

                // Enter Triangle dimensions or Exit, reject all other entries
                switch (menuChoice)
                {
                    case "1":
                        EnterTriangle();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(menuChoice + " is not a valid selection \nPlease select only 1 or 2");
                        break;
                }
            }
        }

        /// <summary>
        /// Checks validity of each side entered
        /// </summary>
        /// <param name="side">side length entered</param>
        /// <returns></returns>
        public static Boolean Validate(string side)
        {
            string errors = "";
            try
            {
                double.Parse(side); // checks for decimals
                errors = "Side length must be a whole number, no decimals \n";
                if (int.Parse(side) > 0) // checks for positive Int
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("A triangle must have 3 sides consisting of positive numbers");
                }
            }
            catch (OverflowException ex) // Catches numbers outside of Int range
            {
                Console.WriteLine("Side length cannot be greater than 2,147,483,647");
            }
            catch (Exception ex) // catchs all other errors, displays if decimals were found
            {
                Console.WriteLine("That was not a valid number\n" + errors);
                return false;
            }
            return false;
        }

        /// <summary>
        /// Input options for entering triagle dimensions
        /// </summary>
        public static void EnterTriangle()
        {
            string sideA;
            string sideB;
            string sideC;

            Console.WriteLine("Please enter the length of each side");

            // Validates each side, repeats entry as necessary
            do
            {
                Console.Write("Side 1: ");
                sideA = Console.ReadLine();
            } while (!Validate(sideA));

            do
            {
                Console.Write("Side 2: ");
                sideB = Console.ReadLine();
            } while (!Validate(sideB));

            do
            {
                Console.Write("Side 3: ");
                sideC = Console.ReadLine();
            } while (!Validate(sideC));

            // Displays entered dimensions
            Console.WriteLine("\nYou entered these dimensions:");
            Console.WriteLine(sideA + " " + sideB + " " + sideC + "\n");

            // Verifies if values entered can produce a triangle, and what type if they do
            Console.WriteLine(TriangleSolver.Analyze(int.Parse(sideA), int.Parse(sideB), int.Parse(sideC)));
        }
    }
}
