using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int a)
        {
            string day = a switch 
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Число должно быть от 1 до 7"
            };
            return day;
        }
    }
}
