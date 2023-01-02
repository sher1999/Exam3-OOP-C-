using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public abstract class Shape
    {
        protected string _color = "red";
        protected bool _filled = true;

        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            _color = color;
            _filled = filled;
        }
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public bool IsFilled()
        {
            return _filled;
        }
        public void SetFilled(bool filled)
        {
            _filled = filled;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"Shape[color={_color}, filled={_filled}]";
        }


    }

    }
