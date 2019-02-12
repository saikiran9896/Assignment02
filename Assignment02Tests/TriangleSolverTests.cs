using Assignment02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        public void Sides3and3and3forEquilateral()
        {
            //Arrange
            int s1 = 3, s2 = 3, s3 = 3;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Equilateral triangle");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides3and2and2forIsosceles()
        {
            //Arrange
            int s1 = 3, s2 = 2, s3 = 2;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Isosceles triangle");
            Console.WriteLine("Please check the result");
        }

       

        [Test]
        public void Sides0and0and0forNOTPOSSIBLE()
        {
            //Arrange
            int s1 = 0, s2 = 0, s3 = 0;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "All sides enterred are zero, Triangle not possible");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void SidesnegativeforNOTPOSSIBLE()
        {
            //Arrange
            int s1 = -1, s2 = -2, s3 = -3;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "All sides enterred are less then zero, Triangle not possible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides0and1and2forNOTPOSSIBLE()
        {
            //Arrange
            int s1 = 0, s2 = 1, s3 = 2;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "One of the side is Zero, Triangle not Posssible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides0and0and2forNOTPOSSIBLE()
        {
            //Arrange
            int s1 = 0, s2 = 0, s3 = 2;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Two of the side are Zero, Triangle not Posssible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void SidesNegateiveand1and2forNOTPOSSIBLE()
        {
            //Arrange
            int s1 = -5, s2 = 1, s3 = 2;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "One of the side is Negative, Triangle not Posssible");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void SidesNegateiveand2forNOTPOSSIBLE()
        {
            //Arrange
            int s1 = -5, s2 = -11, s3 = 2;
            
            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Two of the side are Negative, Triangle not Posssible");
            Console.WriteLine("Please check the result");
        }
    }
}