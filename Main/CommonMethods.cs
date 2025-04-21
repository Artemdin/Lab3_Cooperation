using System;

public static class CommonMethods
{

    private static int[]? previousArray = null;
    private static int[][]? previousJaggedArray = null;

    public static int ReadInt(string message, int min = int.MinValue, int max = int.MaxValue)
	{
		int result;
		while (true)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			if (int.TryParse(input, out result) && result >= min && result <= max)
				return result;

			Console.WriteLine("Помилка! Введіть ціле число в допустимому діапазоні.");
		}
	}

	public static int[] InputArray()
	{
        if (previousArray != null)
        {
            Console.Write("Бажаєте використати попередній масив? (y/n): ");
            string reuse = Console.ReadLine()!.Trim().ToLower();
            if (reuse == "y")
            {
                Console.WriteLine("Попередній масив:");
                PrintArray(previousArray);
                return previousArray;
            }
        }

        int size = ReadInt("Введіть кількість елементів масиву: ", 1);
		int[] arr = new int[size];

		Console.Write("Заповнити масив випадково? (y/n): ");
		string choice = Console.ReadLine()!.ToLower();
		if (choice == "y")
		{
			arr = GenerateRandomArray(size);
			Console.WriteLine("Згенеровано масив:");
			PrintArray(arr);
		}
		else if (choice == "n")
		{
			for (int i = 0; i < size; i++)
				arr[i] = ReadInt($"arr[{i}] = ");
		}
		else
		{
			Console.WriteLine("Введено некоректне значення. Повторіть спробу!");
			return InputArray();
		}

        previousArray = arr;
        return arr;
	}

	public static int[] GenerateRandomArray(int size, int min = -100, int max = 100)
	{
		Random rand = new Random();
		int[] arr = new int[size];
		for (int i = 0; i < size; i++)
			arr[i] = rand.Next(min, max + 1);

		return arr;
	}

	public static void PrintArray(int[] arr)
	{
		if (arr.Length == 0)
		{
			Console.WriteLine("Порожній масив.");
			return;
		}

		Console.WriteLine("[" + string.Join(", ", arr) + "]");
	}

	public static int[][] InputJaggedArray()
	{
        if (previousJaggedArray != null)
        {
            Console.Write("Бажаєте використати попередній зубчастий масив? (y/n): ");
            string reuse = Console.ReadLine()!.Trim().ToLower();
            if (reuse == "y")
            {
                Console.WriteLine("Попередній зубчастий масив:");
                PrintJaggedArray(previousJaggedArray);
                return previousJaggedArray;
            }
        }


        int rows = ReadInt("Введіть кількість рядків у масиві: ", 1);

		Console.Write("Заповнити масив випадково? (y/n): ");
		string choice = Console.ReadLine()!.Trim().ToLower();

        int[][] jaggedArray;

        if (choice == "y")
		{
			Random rand = new Random();
            jaggedArray = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				int cols = rand.Next(1, 5);
				jaggedArray[i] = new int[cols];
				for (int j = 0; j < cols; j++)
					jaggedArray[i][j] = rand.Next(-100, 101);
			}

			Console.WriteLine("Згенеровано масив:");
		}
		else if(choice == "n")
		{
			jaggedArray = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				int cols = ReadInt($"Введіть кількість елементів у рядку {i}: ", 1);
				jaggedArray[i] = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					jaggedArray[i][j] = ReadInt($"arr[{i}][{j}] = ");
				}
			}

			Console.WriteLine("Введений масив:");
		}
		else
		{
			Console.WriteLine("Введено некоректне значення. Повторіть спробу!");
			return InputJaggedArray();
		}

        PrintJaggedArray(jaggedArray);
        previousJaggedArray = jaggedArray;
        return jaggedArray;
    }

	public static void PrintJaggedArray(int[][] jaggedArray)
	{
		if (jaggedArray.Length == 0)
		{
			Console.WriteLine("Порожній масив.");
			return;
		}

		foreach (var row in jaggedArray)
		{
			Console.WriteLine("[" + string.Join(", ", row) + "]");
		}
	}
}
