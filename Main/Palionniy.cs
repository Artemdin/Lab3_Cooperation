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
                Console.WriteLine("������� ��������.");
                break;
        }
    }

    private static void Task1()
    {
        Console.WriteLine("�������� 1: �������� T �������� ��������� � ������� K");

        int[] arr = CommonMethods.InputArray();

        int k = CommonMethods.ReadInt("������ ������ K (��������� � 0): ");
        int t = CommonMethods.ReadInt("������ ������� T: ");

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
            CommonMethods.PrintArray(newArr);
        }
        else
        {
            Console.WriteLine("��������� �������� ��������. �������� ������ �� �������.");
        }
    }


    private static void Task2()
    {
        Console.WriteLine("�������� 2: �������� ����� � ������������ ���������");

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

        Console.WriteLine("���������:");
        CommonMethods.PrintJaggedArray(newArr);
    }
}
