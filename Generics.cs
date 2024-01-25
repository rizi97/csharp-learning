using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Fundamentals
{
    internal class Generics
    {
        public static T Add<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;

            return num1 + num2;
        }

        public static bool CompareItems<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public static Type DynamicType<T>(T value) 
        {
            //return value.GetType();
            dynamic modifyNum = value;
            //modifyNum = 12;

            return modifyNum.GetType();
        }
    }
}
