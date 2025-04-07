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
        Console.WriteLine("�������� 2: ������� ������� �䒺���� �������.");
        int[] arr = InputArray();

        if (arr.Length == 0)
        {
            Console.WriteLine("�������� ���������. ����� �������.");
            return;
        }



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
            arr = newArr;
            Console.WriteLine("���������:");
            PrintArray(arr);
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
        int[][] arr = InputArrayzub();

        
        if (arr.Length == 0)
        {
            Console.WriteLine("�������� ���������. ����� �������.");
            return;
        }

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

          
            arr = newArr;


            Console.WriteLine("���������:");
            Console.WriteLine("����� �����:");
            foreach (var row in arr)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
        else
        {
            Console.WriteLine("�� ������� ������ ������������ �������.");
        }
    }
}
