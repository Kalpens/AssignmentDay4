using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainView
{
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if(radius <1)
                return;
            Radius = radius;
        }

        public double Circumference()
        {
            return 2*Math.PI*Radius;
        }

        public double Area()
        {
            return Math.PI*Radius*Radius;
        }
    }
}
