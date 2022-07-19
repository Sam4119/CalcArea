using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Triangle:Figure
    {
        private int _a;
        private int _b;
        private int _c;
        public Triangle(int a,int b, int c ):base()
        {

            _a = a;
            _b = b;
            _c = c;
        }
        public override double CalcArea()
        {
            int P = (_a + _b + _c) / 2;
            return Math.Sqrt(P * (P - _a) * (P - _b) * (P - _c));
        }
    }
}
