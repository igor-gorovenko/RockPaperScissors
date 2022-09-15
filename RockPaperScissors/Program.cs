


class Program
{
    

    static string CompChoose(int a)
    {
        if (a == 0) {
            return "Камень";
        } else if (a == 1)
        {
            return "Ножницы";
        } else
        {
            return "Бумага";
        }
    }

    static string YourChoose(int b)
    {
        if (b == 0)
        {
            return "Камень";
        }
        else if (b == 1)
        {
            return "Ножницы";
        }
        else
        {
            return "Бумага";
        }
    }



    static void Main()
    {
        int countWinX = 0;
        int countWinY = 0;

        Console.WriteLine("Игра до 3 побед. Выберите за что хотите играть?");
        Console.WriteLine("Камень - 0 | Ножницы - 1 | Бумага - 2");

        for (int i = 0; i < 10 && (3 > countWinX && 3 > countWinY); i++)
        {

            Random rand = new Random();
            int x = rand.Next(3);

            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("--- НИЧЬЯ ---");
            }
            else if (x == 0 && y == 1 || x == 1 && y == 2 || x == 2 && y == 0)
            {
                Console.WriteLine($"Выбор противника {CompChoose(x)}, Ваш выбор {YourChoose(y)}.");
                Console.WriteLine("--- ВЫ ПРОИГРАЛИ ---");
                countWinX++;

            }
            else
            {
                Console.WriteLine($"Выбор противника {CompChoose(x)}, Ваш выбор {YourChoose(y)}.");
                Console.WriteLine("--- ВЫ ВЫИГРАЛИ ---");
                countWinY++;
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Игра закончена");
        Console.WriteLine($"Счет противник {countWinX}, Ваш счет {countWinY}");
    }
}
