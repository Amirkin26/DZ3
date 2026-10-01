using Latypova;

class Program
{
    static void Main()
    {
        // Задача 1
        Console.WriteLine("Задача 1");
        Console.WriteLine("Введите 10 чисел:");

        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Число " + (i + 1) + ": ");

            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }
        }

        bool ordered = true;

        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] <= numbers[i - 1])
            {
                ordered = false;
                break;
            }
        }

        if (ordered)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine("Последовательность не упорядочена.");
        }


        // Задача 2
        Console.WriteLine();
        Console.WriteLine("Задача 2");
        Console.WriteLine("Введите номер карты от 6 до 14:");

        int k;

        if (int.TryParse(Console.ReadLine(), out k))
        {
            try
            {
                if (k < 6 || k > 14)
                {
                    throw new Exception("Номер карты должен быть от 6 до 14.");
                }

                Card card = new Card();

                switch (k)
                {
                    case 6:
                        card = new Card(6, "шестерка");
                        break;

                    case 7:
                        card = new Card(7, "семерка");
                        break;

                    case 8:
                        card = new Card(8, "восьмерка");
                        break;

                    case 9:
                        card = new Card(9, "девятка");
                        break;

                    case 10:
                        card = new Card(10, "десятка");
                        break;

                    case 11:
                        card = new Card(11, "валет");
                        break;

                    case 12:
                        card = new Card(12, "дама");
                        break;

                    case 13:
                        card = new Card(13, "король");
                        break;

                    case 14:
                        card = new Card(14, "туз");
                        break;
                }

                Console.WriteLine("Достоинство карты: " + card.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Ошибка. Нужно ввести целое число.");
        }


        // Задача 3
        Console.WriteLine();
        Console.WriteLine("Задача 3");
        Console.WriteLine("Введите профессию:");

        string profession = Console.ReadLine().ToLower();

        if (profession == "jabroni")
        {
            Console.WriteLine("Patron Tequila");
        }
        else if (profession == "school counselor")
        {
            Console.WriteLine("Anything with Alcohol");
        }
        else if (profession == "programmer")
        {
            Console.WriteLine("Hipster Craft Beer");
        }
        else if (profession == "bike gang member")
        {
            Console.WriteLine("Moonshine");
        }
        else if (profession == "politician")
        {
            Console.WriteLine("Your tax dollars");
        }
        else if (profession == "rapper")
        {
            Console.WriteLine("Cristal");
        }
        else
        {
            Console.WriteLine("Beer");
        }


        // Задача 4
        Console.WriteLine();
        Console.WriteLine("Задача 4");
        Console.WriteLine("Введите номер дня недели от 1 до 7:");

        int day;

        if (int.TryParse(Console.ReadLine(), out day))
        {
            if (day >= 1 && day <= 7)
            {
                Days selectedDay = (Days)day;

                Console.WriteLine("День недели: " + selectedDay);
            }
            else
            {
                Console.WriteLine("Ошибка. Номер должен быть от 1 до 7.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка. Нужно ввести целое число.");
        }


        // Задача 5
        Console.WriteLine();
        Console.WriteLine("Задача 5");
        Console.WriteLine("Посчитать количество кукол Hello Kitty и Barbie doll.");

        string[] dolls =
        {
            "Barbie doll",
            "Hello Kitty",
            "Teddy bear",
            "Barbie doll",
            "Car",
            "Hello Kitty",
            "Lego"
        };

        int bag = 0;

        foreach (string doll in dolls)
        {
            if (doll == "Hello Kitty" || doll == "Barbie doll")
            {
                bag++;
            }
        }

        Console.WriteLine("Количество кукол в сумке: " + bag);
    }
}