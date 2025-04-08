using System;

public class Dinov
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

        Console.WriteLine("�������� 2: ������� ������� �䒺���� �������.");
        int[] arr = CommonMethods.InputArray();

       
        int lastindex = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {

            if (arr[i] < 0)
            {
                lastindex = i;
                break;
            }
        }

        if (lastindex != -1)
        {

            int[] newArr = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != lastindex)
                {
                    newArr[j++] = arr[i];
                }
            }
;
            Console.WriteLine("���������:");
            CommonMethods.PrintArray(newArr);
        }
        else
        {
            Console.WriteLine("����� �� ������ �䒺���� ��������!");
        }

    }
	private static void Task2()
	{
		Console.WriteLine("�������� 11: ������ ����� ���� �����, �� ������ ������������ ������� (���� � ����� ����� " +
            "� ����� �������� \n� ��������� ������������ ���������, �� ����� ������ � ���)");
      
        int[][] arr = CommonMethods.InputJaggedArray();

     
        int maxValue = int.MinValue;
        int maxRowIndex = -1;
        int maxColIndex = -1;

        //������ ����������� �����
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] > maxValue)
                {
                    maxValue = arr[i][j];
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

        
        if (maxRowIndex != -1)
        {
            Console.WriteLine($"������������ �������: {maxValue}, ����������� � ����� {maxRowIndex}, ������� {maxColIndex}");

      
            int[][] newArr = new int[arr.Length + 1][];

        
            for (int i = 0; i <= maxRowIndex; i++)
            {
                newArr[i] = arr[i];
            }

           
            newArr[maxRowIndex + 1] = new int[arr[maxRowIndex].Length];  
       
            for (int i = maxRowIndex + 1; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

          

            Console.WriteLine("���������:");
            Console.WriteLine("����� �����:");
            CommonMethods.PrintJaggedArray(newArr);
        }
        else
        {
            Console.WriteLine("�� ������� ������ ������������ �������.");
        }
    }
}
