using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2Program
{
    internal class PointA
    {
        private double x;
        private double y;

        public PointA() : this(0.0, 0.0) { }

        public PointA(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void xMove()
        {
            x = x + double.Parse(Console.ReadLine());
        }

        public void yMove()
        {
            y = y + double.Parse(Console.ReadLine());
        }

        public void getDistance()
        {
            Console.WriteLine(Math.Sqrt(x * x + y * y));
        }

        public double DistantTo(PointA otherPoint)
        {
            double dx = this.x - otherPoint.x;
            double dy = this.y - otherPoint.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
