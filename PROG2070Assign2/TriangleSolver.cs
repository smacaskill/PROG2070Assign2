using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign2
{
    class TriangleSolver
    {
        private int sideA;
        private int sideB;
        private int sideC;

        public TriangleSolver()
        {
            sideA = 1;
            sideB = 2;
            sideC = 3;
        }

        public string Analyze(int sideA, int sideB, int sideC)
        {
            if (sideA + sideB < sideC ||
                sideA + sideC < sideB ||
                sideB + sideC < sideA)
            {
                return "Those values do not form a triangle";
            }
            
            if(sideA == sideB && sideA == sideC)
            {
                return "Those values form an Equilateral Triangle";
            }
            else if (sideA == sideB ||
                sideB == sideC ||
                sideA == sideC)
            {
                return "Those values form an Isosceles Triangle";
            }
            else
            {
                return "Those values form a Scalene Triangle";
            }
        }
    }
}
