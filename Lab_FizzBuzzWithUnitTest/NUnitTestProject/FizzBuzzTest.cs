using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework;
using Lab_FizzBuzzWithUnitTest;

namespace NUnitTestProject
{
    [TestFixture]
    public class FizzBuzzTest
    {
        public static int[] IsDevidedWith3_False_Paras = new int[] { 1, 2 };

        [Test]
        //[TestCaseSource(nameof(IsDevidedWith3_False_Paras))]
        public void IsDevidedWith3_False([Range(1,2)] int v_nValue)
        {
            var result = new FizzBuzz().IsDevidedWith3(v_nValue);
            Assert.IsFalse(result);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void IsDevidedWith3_True(int v_nValue)
        {
            var result = new FizzBuzz().IsDevidedWith3(v_nValue);
            Assert.IsTrue(result);
        }
    }
}
