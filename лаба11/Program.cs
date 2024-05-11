using System;

public class Program
{
    delegate string DayOfWeekDelegate();

    public static void Main()
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        int DayIndex = 0;

        DayOfWeekDelegate getDayOfWeek = () =>
        {
            string day = daysOfWeek[DayIndex];
            DayIndex = (DayIndex + 1) % daysOfWeek.Length;
            return day;
        };

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(getDayOfWeek());
        }
    }
}
