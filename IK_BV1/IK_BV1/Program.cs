using System;
using System.Globalization;
DateTime d;
GregorianCalendar cal = new GregorianCalendar();
int countD, num;
Console.Write("День: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Месяц: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Год: ");
int c = int.Parse(Console.ReadLine());
string dat = $"{c}, {b}, {a}";
if (DateTime.TryParse(dat, out d))
{
    num = cal.GetDayOfYear(d);
    Console.WriteLine($"Номер дня с начала года: {num}");
    if (cal.IsLeapYear(c))
    {
        countD = 366 - num;
    }
    else
    {
        countD = 365 - num;
    }
    Console.WriteLine($"Дней до конца года: {countD}");
}
else
{
    Console.WriteLine("Некорректная дата.");
}
