using System;

namespace ClassLibrary1
{
    public class Library
    {
        public double Circle(int r)
        {

            return Math.PI * r * r;
        }
        public double Triangle(int a , int b, int c)
        {
            int P = (a + b + c) / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
    }
}
