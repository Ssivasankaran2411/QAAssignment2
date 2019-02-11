
using NUnit.Framework;
using QAAssignment2;
using System;


namespace QAAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]

        public void Sides5and5and5Equilateral()

        {

            //Arrange

            int s1 = 5, s2 = 5, s3 = 5;


            
            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(length, "equvilateral");

            Console.WriteLine("Please check the result");

        }
        [Test]

        public void Sides5and4and4Isosceles()

        {

            //Arrange

            int s1 = 5, s2 = 4, s3 = 4;



            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(length, "Triangle is Isosceles");

            Console.WriteLine("Please check the result");

        }


        [Test]

        public void Sides3and5and6Scalene()

        {

            //Arrange

            int s1 = 3, s2 = 5, s3 = 6;

            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(length, "Triangle is Scalene");

            Console.WriteLine("Please check the result");

        }


        [Test]
        public void Invalid()
        {
            //Arrange

            int s1 = 1, s2 = 3, s3 = 5;
            
            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);


            //Assert
            Assert.AreEqual(length, "Invalid triangle");

            Console.WriteLine("Please check the result");
        }

        [Test]
        public void OneNegative()
        {
            //Arrange

            int s1 = -1, s2 = 3, s3 = 5;
            
            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);


            //Assert
            Assert.AreEqual(length, "Negative triangle");

            Console.WriteLine("Please check the result");
        }

        [Test]
        public void TwoNegative()
        {
            //Arrange

            int s1 = -1, s2 = -3, s3 = 5;
           
            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);


            //Assert
            Assert.AreEqual(length, "Negative triangle");

            Console.WriteLine("Please check the result");
        }

        [Test]
        public void negativeandequilateral()
        {
            //Arrange

            int s1 = -1, s2 = 1, s3 = 1;
            
            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);


            //Assert
            Assert.AreEqual(length, "Negative triangle");

            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Twoone()
        {
            //Arrange

            int s1 = 1, s2 = 1, s3 = 3;
            
            //Act

            String length = TriangleSolver.analyze(s1, s2, s3);


            //Assert
            Assert.AreEqual(length, "Invalid triangle");

            Console.WriteLine("Please check the result");
        }

    }
}