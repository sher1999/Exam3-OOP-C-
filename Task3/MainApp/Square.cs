using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Square : Rectangle
    {
        private double _side;
        public Square()
        {

        }
        public Square(double side)
        {
            _side = side;
        }
        public Square(double side, string color, bool filled)
        {
           _side=side;
           _color =color;
           _filled=filled;

            
        }
        public double GetSide()
        {
            return _side;
        }
        public void SetSide(double side)
        {
         _side= side;
        }
        public override void SetWidth(double side)
        {

            _width = side;
         
        }
        public override void SetLength(double side)
        {

            _lenght = side;
        }
        public override string ToString()
        {
            return $"Square[{base.ToString()}]";
        }

    }
}
