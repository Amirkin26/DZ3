
class Program
{
    static void Main()
    {
        // Упражнение 4.1
        Console.WriteLine("Упражнение 4.1");
        Console.WriteLine("Введите номер дня в году от 1 до 365:");

        int day;

        if (int.TryParse(Console.ReadLine(), out day))
        {
            if (day >= 1 && day <= 365)
            {
                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int month = 1;

                while (day > daysInMonth[month - 1])
                {
                    day -= daysInMonth[month - 1];
                    month++;
                }

                Console.WriteLine("Месяц: " + month);
                Console.WriteLine("День: " + day);
            }
            else
            {
                Console.WriteLine("Число должно быть от 1 до 365.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }


        // Упражнение 4.2
        Console.WriteLine();
        Console.WriteLine("Упражнение 4.2");
        Console.WriteLine("Введите номер дня в году от 1 до 365:");

        if (int.TryParse(Console.ReadLine(), out day))
        {
            try
            {
                if (day < 1 || day > 365)
                {
                    throw new Exception("Число должно быть от 1 до 365.");
                }

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int month = 1;
                int currentDay = day;

                while (currentDay > daysInMonth[month - 1])
                {
                    currentDay -= daysInMonth[month - 1];
                    month++;
                }

                Console.WriteLine("Месяц: " + month);
                Console.WriteLine("День: " + currentDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }


        // Домашнее задание 4.1
        Console.WriteLine();
        Console.WriteLine("Домашнее задание 4.1");
        Console.WriteLine("Введите год:");

        int year;

        if (int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Введите номер дня в году:");

            if (int.TryParse(Console.ReadLine(), out day))
            {
                bool leapYear = (year % 400 == 0) ||
                                (year % 4 == 0 && year % 100 != 0);

                int maxDays;

                if (leapYear)
                    maxDays = 366;
                else
                    maxDays = 365;

                try
                {
                    if (day < 1 || day > maxDays)
                    {
                        throw new Exception("Неверный номер дня для данного года.");
                    }

                    int[] daysInMonth;

                    if (leapYear)
                    {
                        daysInMonth = new int[]
                        {
                            31, 29, 31, 30, 31, 30,
                            31, 31, 30, 31, 30, 31
                        };
                    }
                    else
                    {
                        daysInMonth = new int[]
                        {
                            31, 28, 31, 30, 31, 30,
                            31, 31, 30, 31, 30, 31
                        };
                    }

                    int month = 1;
                    int currentDay = day;

                    while (currentDay > daysInMonth[month - 1])
                    {
                        currentDay -= daysInMonth[month - 1];
                        month++;
                    }

                    Console.WriteLine("Год: " + year);
                    Console.WriteLine("Месяц: " + month);
                    Console.WriteLine("День: " + currentDay);

                    if (leapYear)
                        Console.WriteLine("Год високосный.");
                    else
                        Console.WriteLine("Год не високосный.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Исключение: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода дня.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода года.");
        }
    }
}