using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum (int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int IntNumber3 = (int)number3;
            return Math.Min(number1, Math.Min(number2, IntNumber3));
        }

        public int FindMaximum(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int IntNumber3 = (int)number3;
            return Math.Max(number1, Math.Max(number2, IntNumber3));
        }
    }
}
