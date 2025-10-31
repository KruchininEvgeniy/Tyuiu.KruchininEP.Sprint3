using Tyuiu.KruchininEP.Sprint3.Task4.V29.Lib;
namespace Tyuiu.KruchininEP.Sprint3.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кручинин Е. П. | РППб25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Использование операторов continue и break в цикла                      *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #29                                                                  *");
            Console.WriteLine("* Выполнил: Кручинин Е. П. | РППб25-1                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции  *");
            Console.WriteLine("* y=cos(x)/xПри х = 0 пропустить значение.Полученные значения суммировать.     *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}