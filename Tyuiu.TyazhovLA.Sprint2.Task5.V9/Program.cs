using Tyuiu.TyazhovLA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.TyazhovLA.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор Switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m       *");
            Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным n и m определить дату*");
            Console.WriteLine("* следующего дня (принять, что n и m не характеризуют 31 декабря).        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текущий месяц:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текущеее число:");
            int m = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDateOfNextDay(m,n);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (m>0 && m<32 && n>0 && n<13) Console.WriteLine("Дата следующего дня:"+ res);
            else Console.WriteLine("Неправильный номер месяца или числа");
            Console.ReadKey();

        }
    }
}
