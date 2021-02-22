using System;

namespace Exo1
{
    public class Rectangle : Shape
    {
        private float _width;

        private float _heigth;

        public Rectangle(float width, float heigth)
        {
            if (width <= 0)
            {
                width = 0.1f;
            }
            _width = width;

            if (heigth <= 0)
            {
                heigth = 0.1f;
            }
            _heigth = heigth;
        }

        public override float Area()
        {
            return _width * _heigth;
        }

        public override float Perimeter()
        {
            return _width * 2 + _heigth * 2;
        }

        public override string ToString()
        {
            return $"Rectangle de longueur {_width} et de hauteur {_heigth}";
        }

        public float Diagonal()
        {
            return MathF.Sqrt(_width * _width + _heigth * _heigth);
        }
        
        public override string DisplayShape()
        {
            string toDisplay = "";
            toDisplay += "\n" + DisplayLineVraiCarre((int)_width);
            for (int i = 1; i <= _heigth; i++)
            {
                toDisplay += "\n" + mainChar + ToStringLineChar((int)_width * 2 + 1, ' ') + mainChar;
            }
            toDisplay += "\n" + DisplayLineVraiCarre((int)_width);
            return toDisplay;
        }
    }
}