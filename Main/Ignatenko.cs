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

    private static void Task1()
    {
        Console.WriteLine("6. Знищити всі елементи з парними індексами");

        int[] arr = CommonMethods.InputArray();
        
        int newSize = arr.Length / 2;
        int[] newArr = new int[newSize];

        for (int i = 1, j = 0; i < arr.Length; i += 2)
        {
            newArr[j++] = arr[i];
        }

        Console.WriteLine("Результат:");
        CommonMethods.PrintArray(newArr);
    }

    private static void Task2()
    {
        Console.WriteLine("2. Додати К рядків у початок зубчастого масиву");

        int[][] jaggedArray = CommonMethods.InputJaggedArray();
        
        int K = CommonMethods.ReadInt("Введіть кількість рядків для додавання в початок: ", 1);
        int[][] newJaggedArray = new int[K + jaggedArray.Length][];

        for (int i = 0; i < K; i++)
        {
            newJaggedArray[i] = new int[] { 0 };
        }

        Array.Copy(jaggedArray, 0, newJaggedArray, K, jaggedArray.Length);
        jaggedArray = newJaggedArray;

        Console.WriteLine("Результат:");
        CommonMethods.PrintJaggedArray(jaggedArray);
    }
}
