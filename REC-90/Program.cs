using System;
using System.Globalization;

namespace REC_90
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            Console.WriteLine(day == 7 ? days[0] : day <= 6 && day >= 1 ? days[day] : "Введенное число не соответствует номеру дня недели");
            Console.ReadKey();
        }
    }
}
