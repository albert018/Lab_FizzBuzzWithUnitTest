using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_FizzBuzzWithUnitTest;

namespace UnitTestProject
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void IsDevidedWith3_1()
        {
            bool lResult = new FizzBuzz().IsDevidedWith3(1);

            Assert.AreEqual(false, lResult);
        }

        [TestMethod]
        public void IsDevidedWith3_2()
        {
            bool lResult = new FizzBuzz().IsDevidedWith3(2);

            Assert.AreEqual(false, lResult);
        }

        [TestMethod]
        public void IsDevidedWith3_3()
        {
            bool lResult = new FizzBuzz().IsDevidedWith3(3);

            Assert.AreEqual(true, lResult);
        }

        [TestMethod]
        public void IsDevidedWith5_5()
        {
            bool lResult = new FizzBuzz().IsDevidedWith5(5);

            Assert.AreEqual(true, lResult);
        }

        [TestMethod]
        public void IsDevidedWith5_6()
        {
            bool lResult = new FizzBuzz().IsDevidedWith5(6);

            Assert.AreEqual(false, lResult);
        }

        [TestMethod]
        public void Print_3()
        {
            string lResult = new FizzBuzz().Print(3);

            Assert.AreEqual("Fizz", lResult);
        }

        [TestMethod]
        public void Print_5()
        {
            string lResult = new FizzBuzz().Print(5);

            Assert.AreEqual("Buzz", lResult);
        }

        [TestMethod]
        public void Print_7()
        {
            string lResult = new FizzBuzz().Print(7);

            Assert.AreEqual("7", lResult);
        }

        [TestMethod]
        public void Print_12()
        {
            string lResult = new FizzBuzz().Print(12);

            Assert.AreEqual("Fizz", lResult);
        }

        [TestMethod]
        public void Print_15()
        {
            string lResult = new FizzBuzz().Print(15);

            Assert.AreEqual("FizzBuzz", lResult);
        }
    }
}
