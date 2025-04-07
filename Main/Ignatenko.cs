using System;

public class Ignatenko
{
    public static void ExecuteTask(int taskNumber)
    {
        switch (taskNumber)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            default:
                Console.WriteLine("Невідоме завдання.");
                break;
        }
    }

    static int ReadInt(string message)
    {
        int result;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out result))
                return result;
            Console.WriteLine("Помилка! Введіть ціле число.");
        }
    }


    static int[] InputArray()
    {
        int size = ReadInt("Введіть кількість елементів масиву: ");

        if (size <= 0)
        {
            Console.WriteLine("Розмір масиву має бути більше 0.");
            return new int[0];
        }

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = ReadInt($"arr[{i}] = ");
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("Масив порожній.");
            return;
        }

        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }


    private static void Task1()
    {
        Console.WriteLine("6. Знищити всі елементи з парними індексами");
        int[] arr = InputArray();

        if (arr.Length == 0)
        {
            Console.WriteLine("Операція неможлива. Масив порожній.");
            return;
        }

        int newSize = arr.Length / 2;
        int[] newArr = new int[newSize];

        for (int i = 1, j = 0; i < arr.Length; i += 2)
        {
            newArr[j++] = arr[i];
        }

        Console.WriteLine("Результат:");
        PrintArray(newArr);
    }

    private static void Task2()
    {
        Console.WriteLine("Виконується завдання 2 студента Ігнатенко Віктор");
        // Логіка для завдання 2
    }
}
