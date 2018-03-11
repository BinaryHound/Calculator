using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorAttempt;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {

        //Gotta check the comparisons...
        Form1 calc = new Form1();

        //Testing for improper evaluation lengths.
        [TestMethod]
        public void TestTokenChecker1()
        {
            calc.operandsStack.Push(1);
            calc.operatorsStack.Push('+');
            //should be an improper evaluation.
            Assert.IsFalse(calc.TokenChecker(calc.operandsStack, calc.operatorsStack));
        }

        //Testing for multi-operator pushes. i.e. 1 + + + 2
        [TestMethod]
        public void TestTokenChecker2()
        {
            calc.operandsStack.Push(1);
            calc.operatorsStack.Push('+');
            calc.operandsStack.Push(2);
            calc.operandsStack.Push(3);
            Assert.IsTrue(calc.TokenChecker(calc.operandsStack, calc.operatorsStack));
        }
        
        //Testing addition.
        [TestMethod]
        public void TestAddition()
        {
            
        }

        //Testing Subtraction.
        [TestMethod]
        public void TestSubtraction()
        {

        }

        //Testing Multiplication.
        [TestMethod]
        public void TestMultiplication()
        {

        }

        //Testing Division.
        [TestMethod]
        public void TestDivision()
        {

        }
    }
}
