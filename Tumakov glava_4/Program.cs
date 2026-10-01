using System;

class Program
{
    static void Main()
    {
        //Домашнее задание 4.1

        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер дня в году: ");
        int day = Convert.ToInt32(Console.ReadLine());

        // Сколько дней в феврале
        int feb = 28;
        if (year % 4 == 0 && year % 100 != 0) feb = 29;
        if (year % 400 == 0) feb = 29;

        // Сколько всего дней в году
        int maxDay = 365;
        if (feb == 29) maxDay = 366;

        if (day < 1 || day > maxDay)
        {
            Console.WriteLine("Ошибка!");
        }
        else
        {
            int month = 1;          // номер месяца, начиная с января = 1
            int daysInMonth = 31;   // сколько дней в указанном месяце

            // Пока номер дня больше, чем может быть дней в месяце, будем вычитать количество дней этого месяца и проверять следующий
            while (day > daysInMonth)
            {
                day = day - daysInMonth;
                month = month + 1;

                // Сколько дней в новом месяце:
                if (month == 2) daysInMonth = feb;
                else if (month == 4 || month == 6 || month == 9 || month == 11) daysInMonth = 30;
                else daysInMonth = 31;
            }

            // Определим название месяца
            string name = "";
            if (month == 1) name = "января";
            else if (month == 2) name = "февраля";
            else if (month == 3) name = "марта";
            else if (month == 4) name = "апреля";
            else if (month == 5) name = "мая";
            else if (month == 6) name = "июня";
            else if (month == 7) name = "июля";
            else if (month == 8) name = "августа";
            else if (month == 9) name = "сентября";
            else if (month == 10) name = "октября";
            else if (month == 11) name = "ноября";
            else name = "декабря";

            Console.WriteLine(day + " " + name);
        }
    }
}