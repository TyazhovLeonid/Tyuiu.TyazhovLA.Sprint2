using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int a)
        {
            string day = a switch 
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => "Число должно быть от 1 до 7"
            };
            return day;
        }
    }
}
