using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_FizzBuzzWithUnitTest
{
    public class FizzBuzz
    {
        public bool IsDevidedWith3(int v_nValue)
        {
            return v_nValue % 3 == 0 ? true : false;
        }

        public bool IsDevidedWith5(int v_nValue)
        {
            return v_nValue % 5 == 0 ? true : false;
        }

        public string Print(int v_nValue)
        {
            if (IsDevidedWith3(v_nValue) && IsDevidedWith5(v_nValue))
                return "FizzBuzz";
            else if (IsDevidedWith3(v_nValue))
                return "Fizz";
            else if (IsDevidedWith5(v_nValue))
                return "Buzz";
            return v_nValue.ToString();
        }
    }
}
