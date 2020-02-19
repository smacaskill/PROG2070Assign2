using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG2070Assign2;

// Unit Tests for TriangleSolver class
// Sandy Macaskill
// Feb 2020
namespace PROG2070Assign2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        /// <summary>
        /// Test for all sides being equal
        /// </summary>
        [Test]
        public void AnalyzeMethod_AllSidesAreEqual_5()
        {
            int sideA = 5;
            int sideB = 5;
            int sideC = 5;

            string result = TriangleSolver.Analyze(sideA, sideB, sideC);

            Assert.AreEqual("Those values form an Equilateral Triangle", result);
        }

        /// <summary>
        /// Test for all sides being equal, but negative
        /// </summary>
        [Test]
        public void AnalyzeMethod_AllSidesAreEqual_Negative5()
        {
            int sideA = -5;
            int sideB = -5;
            int sideC = -5;

            string result = TriangleSolver.Analyze(sideA, sideB, sideC);

            Assert.AreEqual("Those values do not form a triangle", result);
        }

        /// <summary>
        /// Test for two sides being equal
        /// </summary>
        [Test]
        public void AnalyzeMethod_TwoSidesAreEqual_5And6()
        {
            int sideA = 5;
            int sideB = 5;
            int sideC = 6;

            string result = TriangleSolver.Analyze(sideA, sideB, sideC);

            Assert.AreEqual("Those values form an Isosceles Triangle", result);
        }

        /// <summary>
        /// Test for all sides being different values
        /// </summary>
        [Test]
        public void AnalyzeMethod_NoSidesAreEqual_5And6And7()
        {
            int sideA = 5;
            int sideB = 6;
            int sideC = 7;

            string result = TriangleSolver.Analyze(sideA, sideB, sideC);

            Assert.AreEqual("Those values form a Scalene Triangle", result);
        }

        /// <summary>
        /// Test for one side having a zero value
        /// </summary>
        [Test]
        public void AnalyzeMethod_ZeroValueForSideC_0()
        {
            int sideA = 5;
            int sideB = 6;
            int sideC = 0;

            string result = TriangleSolver.Analyze(sideA, sideB, sideC);

            Assert.AreEqual("Those values do not form a triangle", result);
        }

        /// <summary>
        /// Test for Sum of 2 sides being less than the 3rd side
        /// </summary>
        [Test]
        public void AnalyzeMethod_SumOfTwoSidesLessThanThirdSide_5And10And30()
        {
            int sideA = 5;
            int sideB = 10;
            int sideC = 30;

            string result = TriangleSolver.Analyze(sideA, sideB, sideC);

            Assert.AreEqual("Those values do not form a triangle", result);
        }
    }
}
