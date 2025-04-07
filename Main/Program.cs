using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("==================== ГОЛОВНЕ МЕНЮ ====================");
            Console.WriteLine("Оберіть студента (введіть номер) або 0 для виходу:");
            Console.WriteLine("  1 - Пальонний Назар");
            Console.WriteLine("  2 - Дінов Артем");
            Console.WriteLine("  3 - Ігнатенко Віктор");
            Console.WriteLine("======================================================");
            Console.Write("Ваш вибір: ");

            if (!int.TryParse(Console.ReadLine(), out int studentChoice) || studentChoice == 0)
                break;

            Console.WriteLine("\n=== Завдання ===");
            Console.WriteLine("Оберіть номер завдання:");
            Console.WriteLine("  1 - Завдання 1");
            Console.WriteLine("  2 - Завдання 2");
            Console.WriteLine("=================");
            Console.Write("Ваш вибір: ");

            if (!int.TryParse(Console.ReadLine(), out int taskChoice) || (taskChoice != 1 && taskChoice != 2))
            {
                Console.WriteLine("Невірний вибір завдання! Спробуйте ще раз.\n");
                continue;
            }

            switch (studentChoice)
            {
                case 1:
                    Console.WriteLine("\nВиконання завдання студента Пальонний Назар");
                    Palyony.ExecuteTask(taskChoice);
                    break;
                case 2:
                    Console.WriteLine("\nВиконання завдання студента Дінов Артем");
                    Dinov.ExecuteTask(taskChoice);
                    break;
                case 3:
                    Console.WriteLine("\nВиконання завдання студента Ігнатенко Віктор");
                    Ignatenko.ExecuteTask(taskChoice);
                    break;
                default:
                    Console.WriteLine("Невірний вибір студента! Спробуйте ще раз.\n");
                    break;
            }
        }

        Console.WriteLine("\nПрограма завершена.");
    }
}
