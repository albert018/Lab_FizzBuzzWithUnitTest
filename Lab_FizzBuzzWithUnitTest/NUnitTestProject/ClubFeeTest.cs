using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using Lab_FizzBuzzWithUnitTest;

namespace NUnitTestProject
{
    [TestFixture]
    public class ClubFeeTest
    {
        private static List<TestCaseData> _Persons2 = new List<TestCaseData>
        {
            new TestCaseData(new Person { Gender = GenderOption.Female }, 500m),
                //.SetName("Female"),
            new TestCaseData(new Person { Gender = GenderOption.Male }, 1000m)
                //.SetName("Male")
        };

        //測試邏輯相同，但不用 ValuesAttribute 或 Range 來批次傳入參數，
        //改用 TestCaseData 來傳入並且定義預期的結果
        [TestCaseSource(nameof(_Persons2))]
        public void FeeManager_GetFee_Test(Person v_Person, decimal v_nExpected)
        {
            //arrange
            //var P1 = new Person { Gender = GenderOption.Male };

            //act
            var nResult = new FeeManagerV1().GetFee(v_Person);

            //assert
            Assert.AreEqual(v_nExpected, nResult);
        }

        //依 Class 的屬性來當條件，並定義不同的回傳值
        [Test]
        public void CheckManamager_GetFee_Test()
        {
            //arrange
            var Person = new List<Person>()
            {
                new Person {Gender= GenderOption.Male },
                new Person {Gender= GenderOption.Female },
                new Person {Gender= GenderOption.Female }
            };

            var FeeManager = MockRepository.GenerateStub<IFeeManager>();
            FeeManager.Stub(x =>
                x.GetFee(Arg<Person>.Matches(y=>y.Gender== GenderOption.Male))
            ).Return(500);
            FeeManager.Stub(x =>
                x.GetFee(Arg<Person>.Matches(y => y.Gender == GenderOption.Female))
            ).Return(100);

            //act
            var Check = new CheckManamager(FeeManager);
            decimal nResult = Check.GetFee(Person);

            //assert
            Assert.AreEqual(700, nResult);
        }

        //計算 GetFee 被呼叫的次數是否正確
        [Test]
        public void CheckManamager_GetFee_Test_Count()
        {
            //arrange
            var Person = new List<Person>()
            {
                new Person {Gender= GenderOption.Male },
                new Person {Gender= GenderOption.Female },
                new Person {Gender= GenderOption.Female }
            };
            var mock = new MockRepository();
            var FeeManager = mock.StrictMock<IFeeManager>();

            //act
            using (mock.Record())
            {
                FeeManager.GetFee(Person[0]);
                LastCall.IgnoreArguments().Return(1000m).Repeat.Times(2);
            }

            //assert
            using (mock.Playback())
            {
                var Check = new CheckManamager(FeeManager);
                decimal nResult = Check.GetFee(Person);
            }
        }
    }
}
