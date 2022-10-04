using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 3, 3, 9)]
        [InlineData(9, 9, 9, 27)]//Add test data <-------
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            var test = new Calculator(); //Arrange
                                              // create a Calculator object


            //Act
            var actual = test.Add(num1, num2, num3);  // call the Add method that is located in the Calculator class
                                                      // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual); //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,3,0)]
        [InlineData(6,5,1)]//dd test data <-------
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtest = new Calculator();
            //Act
            var actual = subtest.Subtract(minuend, subtrhend, expected);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1)]//Add test data <-------
        public void Multiply(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            var multest = new Calculator(); //Arrange

            //Act
            var actual = multest.Multiply(num1, num2, expected);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(9,3,3)]//Add test data <-------
        public void Divide(int num1, int num2, int expected)
        {
            var divtest = new Calculator(); //Arrange

            //Act
            var actual = divtest.Divide(num1, num2, expected);

            Assert.Equal(expected, actual);//Assert

        }

    }
}
