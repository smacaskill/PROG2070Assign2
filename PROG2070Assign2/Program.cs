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
                        string sideA;
                        string sideB;
                        string sideC;

                        Console.WriteLine("Please enter the length of each side");
                        Console.Write("Side 1: ");
                        sideA = Console.ReadLine();
                        Console.Write("Side 2: ");
                        sideB = Console.ReadLine();
                        Console.Write("Side 3: ");
                        sideC = Console.ReadLine();

                        Console.WriteLine("You entered these dimensions:");
                        Console.WriteLine(sideA + " " + sideB + " " + sideC);
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select only 1 or 2");
                        break;
                }
            }
        }
    }
}
