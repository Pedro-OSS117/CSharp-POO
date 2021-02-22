using System;

namespace Exo1
{
    public class Square : Shape
    {
        private float _width;

        public Square(float width)
        {
            if (width <= 0)
            {
                width = 0.1f;
            }
            _width = width;
        }

        public override float Area()
        {

            return _width * _width;
        }

        public override float Perimeter()
        {
            return _width * 4;
        }

        public override string ToString()
        {
            return $"Square de coté : {_width}.";
        }

        public float Diagonal()
        {
            return MathF.Sqrt(_width * _width + _width * _width);
        }        

        public override string DisplayShape()
        {
            string toDisplay = "";
            toDisplay += "\n" + DisplayLineVraiCarre((int)_width);
            for (int i = 1; i <= _width; i++)
            {
                toDisplay += "\n" + mainChar + ToStringLineChar((int)_width * 2 + 1, ' ') + mainChar;
            }
            toDisplay += "\n" + DisplayLineVraiCarre((int)_width);
            return toDisplay;
        }
    }
}