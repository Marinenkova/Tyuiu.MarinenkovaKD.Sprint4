using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MarinenkovaKD.Sprint4.Task7.V10.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint4.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "695847142536";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Мариненкова К. Д. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Мариненкова Кристина Дмитриевна | ИСТНб-23-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 695847142536. Преобразуйте            *");
            Console.WriteLine("* ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Сумма нечетных чисел = " + res);
            Console.ReadKey();
        }
    }
}
