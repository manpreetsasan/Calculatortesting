using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace Calculator
{
    public class Class1
    {

[TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input20and20_Returns40()
        {
                //Arrange
            double number1 = 20;
            double number2 = 20;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
    }
}
