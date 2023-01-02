using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Rectangle : Shape
    {
        protected double _width = 1.0;
        protected double _lenght = 1.0;

        public Rectangle()
        {

        }
        public Rectangle(double width, double length)
        {
            _width = width;
            _lenght = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            _width = width;
            _lenght = length;
        }



        public double GetWidth()
        {
            return _width;
        }
        public virtual void SetWidth(double width)
        {
            _width = width;
        }
        public double GetLength()
        {
            return _lenght;
        }
        public virtual void SetLength(double length)
        {
            _lenght = length;
        }
        public override double GetArea()
        {
            return _width * _lenght;
        }
        public override double GetPerimeter()
        {
            return 2 * (_width + _lenght);
        }
        public override string ToString()
        {
            return $"Cercle[{base.ToString()}, width={_width}, length={_lenght}]";
        }
    }
}
