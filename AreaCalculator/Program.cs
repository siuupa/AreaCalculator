using System;

namespace AreaCalculator
{
    public class Program
    {
        public float AreaOfTriangle(int a, int h)
        {
            return ((float)(a * h) / 2);
        }

        public int AreaOfSquare(int a)
        {
            return a * a;
        }

        public int AreaOfRectangle(int a, int b)
        {
            return a * b;
        }

        public float AreaOfTrapeze(int a, int b, int h)
        {
            return ((a + b) * h) / 2;
        }

        public float AreaOfCircle(int r)
        {
            return ((float)(r * r * 3.14));
        }
    }
}
