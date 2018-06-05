using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc calc = new Calc();
        }



        [TestMethod]
        public void TestInvalidInput()
        {
            Calc calc = new Calc();

            try
            {
                int result = calc.Calculate("abcd");
                Assert.Fail();
            }
            catch(InvalidOperationException ex)
            {

            }

      
        }


        [TestMethod]
        public void OnePlusOne()
        {
            Calc calc = new Calc();

            int result = calc.Calculate("1+1");

            Assert.AreEqual(2, result);
        }


        void DoSumTest(string input,int expected)
        {
            Calc calc = new Calc();

            int result = calc.Calculate(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoPlusTwo()
        {
         

            DoSumTest("2+2",4);


        }


        [TestMethod]
        public void FourPlusEleven()
        {
            DoSumTest("4+11", 15);

        }

        [TestMethod]
        public void TwoMinusOne()
        {
            DoSumTest("2-1", 1);
        }

        [TestMethod]
        public void FiveMinusTwo()
        {
            DoSumTest("5-2", 3);
        }

        [TestMethod]
        public void FiveTimesTwo()
        {
            DoSumTest("5*2",10);
        }
        [TestMethod]
        public void EightDividedByTwo()
        {
            DoSumTest("8/2", 4);
        }
   
        public void EightDividedBeTwoPlusTree()
        {
            DoSumTest("8/2+3", 4);
        }
    }
}
