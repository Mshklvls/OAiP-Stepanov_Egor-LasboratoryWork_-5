using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2Program
{
    internal class Point
    {
        private double xCoord;
        private double yCoord;

        public void xMove()
        {
            xCoord = xCoord + double.Parse(Console.ReadLine());
        }

        public void yMove()
        {
            yCoord = yCoord + double.Parse(Console.ReadLine());
        }

        public void getDistance()
        {
            Console.WriteLine(Math.Sqrt(xCoord * xCoord + yCoord * yCoord));
        }
    }
}
