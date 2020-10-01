using System;
using System.Collections.Generic;
using System.Text;

namespace RechargingProject
{
    class floatNumbers
    {
        private float real;
        public floatNumbers() : this(0) { }
        public floatNumbers(float a) 
        {
            real = a;
        }
        public static floatNumbers operator ++(floatNumbers number) 
        {
            return new floatNumbers(number.real + 1);
        }
        public static floatNumbers operator --(floatNumbers number) 
        {
            return new floatNumbers(number.real - 1);
        }
    }
}
