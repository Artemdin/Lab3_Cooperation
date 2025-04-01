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
                Console.WriteLine("������� ��������.");
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
            Console.WriteLine("�������! ������ ���� �����.");
        }
    }


    static int[] InputArray()
    {
        int size = ReadInt("������ ������� �������� ������: ");

        if (size <= 0)
        {
            Console.WriteLine("����� ������ �� ���� ����� 0.");
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
            Console.WriteLine("����� �������.");
            return;
        }

        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }


    private static void Task1()
    {
        Console.WriteLine("6. ������� �� �������� � ������� ���������");
        int[] arr = InputArray();

        if (arr.Length == 0)
        {
            Console.WriteLine("�������� ���������. ����� �������.");
            return;
        }

        int newSize = arr.Length / 2;
        int[] newArr = new int[newSize];

        for (int i = 1, j = 0; i < arr.Length; i += 2)
        {
            newArr[j++] = arr[i];
        }

        Console.WriteLine("���������:");
        PrintArray(newArr);
    }

    private static void Task2()
    {
        Console.WriteLine("���������� �������� 2 �������� ��������� ³����");
        // ����� ��� �������� 2
    }
}
