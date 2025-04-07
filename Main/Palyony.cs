using System;

public class Palyony
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
    private static int[][] InputArrayzub()
    {
        Console.WriteLine("������ ������� ����� ������:");
        int rowCount = int.Parse(Console.ReadLine());

        int[][] arr = new int[rowCount][];

        for (int i = 0; i < rowCount; i++)
        {
            Console.WriteLine($"������ �������� ��� ����� {i + 1} (����� �����):");
            string[] input = Console.ReadLine().Split(' ');
            arr[i] = input.Select(int.Parse).ToArray();
        }

        return arr;
    }

    private static void Task1()
    {
        Console.WriteLine("�������� 1: �������� T �������� ��������� � ������� K");

        int[] arr = InputArray();
        if (arr.Length == 0) return;

        int k = ReadInt("������ ������ K (��������� � 0): ");
        int t = ReadInt("������ ������� T: ");

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

            Console.WriteLine("���������:");
            PrintArray(newArr);
        }
        else
        {
            Console.WriteLine("��������� �������� ��������. �������� ������ �� �������.");
        }
    }


    private static void Task2()
    {
        Console.WriteLine("�������� 2: �������� ����� � ������������ ���������");

        int[][] arr = InputArrayzub();
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

        Console.WriteLine("���������:");
        foreach (var row in newArr)
        {
            Console.WriteLine(string.Join(", ", row));
        }
    }
}
