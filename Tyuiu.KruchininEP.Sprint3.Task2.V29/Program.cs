using Tyuiu.KruchininEP.Sprint3.Task2.V29.Lib;
namespace Tyuiu.KruchininEP.Sprint3.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кручинин Е. П. | РППб25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Кручинин Е. П.               | РППб25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
            Console.WriteLine("* ряда по формуле, при a=0,5                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumSeries(1, 1, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}