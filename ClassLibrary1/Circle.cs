using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     class Circle:Figure
    {
        private double _r;
        public Circle(double r) : base ()
        {
            if(r<=0)
            {
                throw new ArgumentException("Отрицательный радиус!");
            }
            _r= r;

        }
        public override double CalcArea()
        {
            return Math.PI * _r * _r;
        }
       
    }
}
