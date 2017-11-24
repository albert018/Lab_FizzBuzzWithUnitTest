using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_FizzBuzzWithUnitTest
{
   
    public interface IFeeManager
    {
        decimal GetFee(Person v_Person);
    }

    public class FeeManagerV1 : IFeeManager
    {
        public decimal GetFee(Person v_Person)
        {
            return v_Person.Gender == GenderOption.Male ? 1000m : 500m;
        }
    }

    public enum GenderOption
    {
        Male=0,
        Female
    }

    public class Person
    {
        public GenderOption Gender;
    }

    public class CheckManamager
    {
        private IFeeManager _FeeManager;

        public CheckManamager(IFeeManager v_FeeNamager)
        {
            _FeeManager = v_FeeNamager;
        }

        public decimal GetFee(List<Person> v_Person)
        {
            decimal nTotal = 0;

            foreach (var item in v_Person)
                nTotal += _FeeManager.GetFee(item);

            return nTotal;
        }
    }
}
