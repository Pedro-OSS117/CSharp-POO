using System;

namespace Exo1
{
    public class Circle : Shape
    {
        private float _radius;

        public Circle(float radius)
        {
            if(radius <= 0)
            {
                radius = 0.1f;
            }
            _radius = radius;
        }

        public override float Area()
        {
            return _radius*_radius * MathF.PI;
        }

        public override float Perimeter()
        {
            return 2 * MathF.PI * _radius;
        }

        public override string ToString()
        {
            return $"Circle de rayon {_radius}";
        }

        public float Diameter()
        {
            return _radius * 2;
        }
        
        public override string DisplayShape()
        {
            return "TODO !";
        }
    }
}