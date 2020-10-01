using System;
using System.Collections.Generic;
using System.Text;

namespace RechargingProject
{
    class IntRecharge 
    {
        private dynamic number;
        private dynamic second;
        public IntRecharge() : this(0) { }

        public IntRecharge(int a) 
        {
            number = a;
        }

        public static IntRecharge operator +(IntRecharge number, IntRecharge second) 
        {
            return new IntRecharge(number.number + second.second);
        }
        public static IntRecharge operator -(IntRecharge number, IntRecharge second) 
        {
            return new IntRecharge(number.number - second.second);
        }
    }
}
