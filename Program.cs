using System;

namespace PatikaDatetimeandMathMetotlari;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("******************** DateTime Kütüphanesi********************");
        Console.WriteLine(DateTime.Now);
        System.Console.WriteLine(DateTime.Now.Date);
        System.Console.WriteLine(DateTime.Now.Day);
        System.Console.WriteLine(DateTime.Now.Month);
        System.Console.WriteLine(DateTime.Now.Year);
        System.Console.WriteLine(DateTime.Now.Hour);
        System.Console.WriteLine(DateTime.Now.Minute);
        System.Console.WriteLine(DateTime.Now.Second);

        System.Console.WriteLine(DateTime.Now.DayOfWeek);
        System.Console.WriteLine(DateTime.Now.DayOfYear);

        System.Console.WriteLine(DateTime.Now.AddDays(1));
        System.Console.WriteLine(DateTime.Now.AddTicks(10));
        System.Console.WriteLine(DateTime.Now.AddHours(5));
        System.Console.WriteLine(DateTime.Now.AddMinutes(30));
        System.Console.WriteLine(DateTime.Now.AddMonths(6));
        System.Console.WriteLine(DateTime.Now.AddYears(10));

        //DateTime format
        System.Console.WriteLine(DateTime.Now.ToString("dd")); //day of the month
        System.Console.WriteLine(DateTime.Now.ToString("ddd")); //day of the week (abbreviated)
        System.Console.WriteLine(DateTime.Now.ToString("dddd")); //day of the week (full)

        System.Console.WriteLine(DateTime.Now.ToString("MM")); //04
        System.Console.WriteLine(DateTime.Now.ToString("MMM")); //Sat
        System.Console.WriteLine(DateTime.Now.ToString("MMMM")); //Saturday

        System.Console.WriteLine(DateTime.Now.ToString("yy")); //24
        System.Console.WriteLine(DateTime.Now.ToString("yyyy")); //2024

        // Math kütüphanesi
        System.Console.WriteLine("******************** Math Kütüphanesi********************");
        System.Console.WriteLine(Math.Abs(-25));
        System.Console.WriteLine(Math.Sin(10));
        System.Console.WriteLine(Math.Cos(20));
        System.Console.WriteLine(Math.Tan(50));

        System.Console.WriteLine(Math.Ceiling(22.3)); //23
        System.Console.WriteLine(Math.Round(22.6));
        System.Console.WriteLine(Math.Floor(22.7));

        System.Console.WriteLine(Math.Max(2,6));
        System.Console.WriteLine(Math.Min(6,9));

        System.Console.WriteLine(Math.Pow(3,4)); // 3^4=81
        System.Console.WriteLine(Math.Sqrt(9)); //karekökünü alır
        System.Console.WriteLine(Math.Log(9)); // 9un e tabanındaki logaritmik karşılığı
        System.Console.WriteLine(Math.Exp(3)); // e üzeri 3 verir
        System.Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığını
    }
}
