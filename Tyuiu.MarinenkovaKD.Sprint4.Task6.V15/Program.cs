using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MarinenkovaKD.Sprint4.Task6.V15.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint4.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #4 | Выполнила: Мариненкова К. Д. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Мариненкова Кристина Дмитриевна | ИСТНб-23-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Чикаго, Хьюстон, Феникс,                   *");
            Console.WriteLine("* Филадельфия, Сан - Антонио, Сан - Диего, Даллас] используя              *");
            Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых меньше 7.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var cities = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("Исходный массив:" );
            for (int i = 0; i <= cities.Length - 1; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(cities);

            Console.WriteLine("Кол-во элементов, длинна которых < 7 = " + res);
            Console.ReadKey();
        }
    }
}
