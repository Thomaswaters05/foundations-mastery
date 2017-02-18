using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Factorial factorial = new Factorial();
            Assert.IsNotNull(factorial);
     
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial factorial = new Factorial();
            int expectedResult = 6;
            int actualResult = factorial.Iterative(4);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial factorial = new Factorial();
            int expectedResult = 24;
            int actualResult = factorial.Recursive(4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial factorial = new Factorial();

            int expectedResult = 1;
            int actualResult = factorial.Recursive(0);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial factorial = new Factorial();

            int expectedResult = 1;
            int actualResult = factorial.Iterative(1);

            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}
