using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Circle
    {
        private double _radius;
        public const double Pi = 3.14;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            _radius=radius;
        }
        public double GetRadius()
        {
            return  _radius;
        }  
        public void Setradius(double radius)
        {
            _radius = radius;  
        }
        public void GetArea()
        {
            Console.WriteLine("Area circle: "+_radius*_radius*Pi);
        }
        public double GetCircumference()
        {
            return 2 * Pi * _radius;
        }
        public override string ToString()
        {
            return $"Circle[radius={_radius}]";
        }

    }
}
