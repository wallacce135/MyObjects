using System;
using System.Collections.Generic;
using System.Text;

namespace RechargingProject
{
    class Vektor 
    {
        private static int size;
        float[] = ;
        private float veksecond;

        int firstInt;
        int secondInt;

        private float error;

        private float[] array = new float[size];

        public Vektor() : this(0, 0) { }
        public Vektor(float a)        
        {
            vekfirst = a;
        }
        public Vektor(float a, float b)
        {
            vekfirst = a;
            veksecond = b;
        }
        public Vektor(int a, int b) 
        {
            firstInt = a;
            secondInt = b;
        }
        public static Vektor operator +(Vektor number, Vektor second)
        {
            return new Vektor(number.vekfirst + second.veksecond);
        }
        public static Vektor operator -(Vektor number, Vektor second)
        {
            return new Vektor(number.vekfirst - second.veksecond);
        }
        public static Vektor operator *(Vektor number, Vektor second)
        {
            return new Vektor(number.vekfirst * second.veksecond);
        }
        //public static Vektor operator +(int number, int second) 
        //{
        //    return new Vektor(number.firstInt + second.secondInt);
        //}
        //public static Vektor operator -(int number, int second)
        //{
        //    return new Vektor(number.firstInt - second.secondInt);
        //}
        //public static Vektor operator *(int number, int second)
        //{
        //    return new Vektor(number.firstInt * second.secondInt);
        //}
        public static Vektor operator ++(Vektor Num) 
        {
            return new Vektor(Num.vekfirst + 1f);
        }
        public static Vektor operator --(Vektor Num) 
        {
            return new Vektor(Num.vekfirst - 1f);
        }
    }
}
