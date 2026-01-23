using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5true
{
    internal class Time
    {
        private int hour = 0;
        private int minute = 0;

        public void GetMinute()
        {
            Console.WriteLine(hour * 60 + minute);
        }

        public void Read()
        {
            Console.WriteLine("Введите количество часов (от 0 до какого-то большого :) ): ");
            hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество минут (от 0 до 59): ");
            do
            {
                minute = int.Parse(Console.ReadLine());
            } while (minute < 0 || minute > 59);
        }

        public void Display()
        {
            Console.WriteLine("Часы: " +  hour);
            Console.WriteLine("Минуты: " + minute);
        }
    }
}
