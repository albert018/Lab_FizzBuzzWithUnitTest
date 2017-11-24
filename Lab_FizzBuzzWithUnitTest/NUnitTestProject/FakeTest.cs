using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab_FizzBuzzWithUnitTest;

namespace NUnitTestProject
{
    [TestFixture]
    public class FakeTest
    {
        [Test]
        public void GetDateTime_Test()
        {

            var Result = new Helper().GetDateTime();
        }
    }
}
