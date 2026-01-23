using System;
namespace Lab5true
{
    class Program
    {
        static void Main()
        {
            int exit = 0;
            Console.WriteLine("Здравствуйте, эта программма сделана для того, чтобы переводить введёные часы и минуты только в минуты, ведь вы сами вряд-ли сможете это сделать");
            var time = new Time();

            do
            {
                Console.WriteLine("Выберите действие: 0 - ввести данные, 1 - отобразить введённые данные, 2 - сосчитать время, 9 - выход из программы");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        time.Read();
                        break;
                    case 1:
                        time.Display();
                        break;
                    case 2:
                        time.GetMinute();
                        break;
                    case 9:
                        exit = 1;
                        break;
                    default:
                        Console.WriteLine("Выберите от 0 до 2, либо 9!");
                        break;
                }
            } while (exit == 0);
        }
    }
}