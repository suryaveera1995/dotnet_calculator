using System;
using consoleApp;
using Xunit;


namespace unitTest
{
    public class CalculatorTest
    {
        [Fact]
        public void TestSum()
        {
            //Arrange
            Calculator cal = new Calculator();
            //Act
            var mySum=cal.Sum(5,4);
            //Assert
            Assert.IsType<int>(mySum);
            Assert.Equal(9,mySum);
            Assert.NotEqual(10,mySum);
        }

        [Fact]
        public void TestDiff()
        {
            Calculator cal = new Calculator();
            var myDiff=cal.Diff(5,4);
            Assert.IsType<int>(myDiff);
            Assert.Equal(1,myDiff);
            Assert.NotEqual(10,myDiff);
        }

        [Fact]
        public void TestMul()
        {
            Calculator cal = new Calculator();
            var myMul=cal.Mul(5,4);
            Assert.IsType<int>(myMul);
            Assert.Equal(20,myMul);
            Assert.NotEqual(10,myMul);
        }

        [Fact]
        public void TestDiv()
        {
            Calculator cal = new Calculator();
            var myDivi=cal.Divi(15,5);
            Assert.IsType<int>(myDivi);
            Assert.Equal(3,myDivi);
            Assert.NotEqual(10,myDivi);
        }
    }
}
