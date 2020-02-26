using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class for checking if values can make a triangle
// If so, what kind of triangle they produce

// Sandy MacAskill
// Feb 2020

namespace PROG2070Assign2
{

    public static class TriangleSolver
    {
        /// <summary>
        /// Analyzes 3 integers for triangle formation compatibility
        /// </summary>
        /// <param name="sideA">Int greater than 0</param>
        /// <param name="sideB">Int greater than 0</param>
        /// <param name="sideC">Int greater than 0</param>
        /// <returns></returns>
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            // Checks for Sum of 2 sides greater than 3rd side
            if (sideA + sideB <= sideC ||
                sideA + sideC <= sideB ||
                sideB + sideC <= sideA ||
                sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return "Those values do not form a triangle";
            }
            else if(sideA == sideB && sideA == sideC) // Checks for Equilateral values
            {
                return "Those values form an Equilateral Triangle";
            }
            else if (sideA == sideB ||
                sideB == sideC ||
                sideA == sideC) // Checks for Isosceles values
            {
                return "Those values form an Isosceles Triangle";
            }
            else // All other entries produce Scalene
            {
                return "Those values form a Scalene Triangle";
            }
        }
    }
}
