using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice;

            while (1 == 1)
            {
                    Console.WriteLine("\nPlease select one of the following options: ");
                    Console.WriteLine("1. Enter Triangle Dimensions");
                    Console.WriteLine("2. Exit\n");
                    menuChoice = Console.ReadLine();

                // Various responses based on menu selection
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

        public static Boolean Validate(string side)
        {
            string errors = "";
            try
            {
                double.Parse(side);
                errors = "Side length must be a whole number, no decimals \n";
                if (int.Parse(side) > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Number must be greater than 0");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Side length cannot be greater than 2,147,483,647");
            }
            catch (Exception ex)
            {
                Console.WriteLine("That was not a valid number\n" + errors);
                return false;
            }
            return false;
        }

        public static void EnterTriangle()
        {
            TriangleSolver solver = new TriangleSolver();
            string sideA;
            string sideB;
            string sideC;

            Console.WriteLine("Please enter the length of each side");

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

            Console.WriteLine("\nYou entered these dimensions:");
            Console.WriteLine(sideA + " " + sideB + " " + sideC + "\n");
            Console.WriteLine(solver.Analyze(int.Parse(sideA), int.Parse(sideB), int.Parse(sideC)));
        }
    }
}
