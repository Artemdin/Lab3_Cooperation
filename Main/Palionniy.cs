using System;

public class Palionniy
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

    private static void Task1()
    {
        Console.WriteLine("Завдання 1: Видалити T елементів починаючи з індексу K");

        int[] arr = CommonMethods.InputArray();

        int k = CommonMethods.ReadInt("Введіть індекс K (починаючи з 0): ");
        int t = CommonMethods.ReadInt("Введіть кількість T: ");

        if (k >= 0 && k + t <= arr.Length)
        {
            int[] newArr = new int[arr.Length - t];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < k || i >= k + t)
                {
                    newArr[j++] = arr[i];
                }
            }

            Console.WriteLine("Результат:");
            CommonMethods.PrintArray(newArr);
        }
        else
        {
            Console.WriteLine("Неможливо видалити елементи. Перевірте індекс та кількість.");
        }
    }


    private static void Task2()
    {
        Console.WriteLine("Завдання 2: Видалити рядок з максимальним елементом");

        int[][] arr = CommonMethods.InputJaggedArray();
        if (arr.Length == 0) return;

        int max = int.MinValue;
        int maxRow = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            foreach (int value in arr[i])
            {
                if (value > max)
                {
                    max = value;
                    maxRow = i;
                }
            }
        }

        int[][] newArr = new int[arr.Length - 1][];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != maxRow)
            {
                newArr[index++] = arr[i];
            }
        }

        Console.WriteLine("Результат:");
        CommonMethods.PrintJaggedArray(newArr);
    }
}
