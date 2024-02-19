// CalculatorFunctionsTest.cs

using NUnit.Framework;
using CalculatorApp;
using System;
using NUnit.Framework.Legacy;
using System.Numerics;
using Newtonsoft.Json.Linq;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorFunctionsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("cs", "hih")]
        [TestCase(1 / 2, 3 / 4)]    
        [TestCase(2.22, "ss")]
        [TestCase(22345768907899, 34363848940)]
        [TestCase(-29, 89)]
        public void Adding_twonumbers(object input1, object input2)
        {
            //Arrange
            dynamic value1 = input1;
            dynamic value2= input2;

            //Act
            object result = Functions.Addition(input1, input2);

            //assert
          ClassicAssert.AreEqual(value1+value2, result,"Invalid Inputs");



        }



        [Test]
        [TestCase("cs", "hih")]
        [TestCase(1 / 2, 3 / 4)]
        [TestCase(2.22, 3.33)]
        [TestCase(-22345768907899, 34363848940)]
        [TestCase(-29, 89)]
        public void Subtracting_Twonumbers(object input1, object input2)
        {

            //Arrange
            dynamic value1 = input1;
            dynamic value2 = input2;

            //Act
            object result = Functions.Subtract(input1, input2);

            //Assert 
            ClassicAssert.AreEqual(value1-value2, result, "Invalid Inputs");


        }

        [Test]
            [TestCase('s', 's')]
            [TestCase(1 / 2, 3 / 4)]
            [TestCase(2.22, 3.33)]
            [TestCase(223, 676)]
            [TestCase(-29, 89)]
            public  void Multiplying_TwoNumbers(object input1, object input2)
            {
            //Arrange

            dynamic value1 = input1;
            dynamic value2= input2;

            //Act
            object result = Functions.Multiply(input1, input2);

            //Assert 
            ClassicAssert.AreEqual(value1 * value2, result, "Invalid Inputs");



        }


            [Test]
            [TestCase("cs", "hih")]
            [TestCase(33, 33)]
            [TestCase(22, 33)]
            [TestCase(288, 66)]
            [TestCase(773, 89)]
            public void Division_ofTwoNumbers(object input1, object input2)
            {

            //Arrange
            dynamic value1 = input1;
            dynamic value2 = input2;

            //Act
            object result = Functions.Divide(input1, input2);

            //assert
            ClassicAssert.AreEqual(value1 - value2, result, "Invalid Inputs");
        }
    }
}

