using System;

public static class CommonMethods
{
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
		int rows = ReadInt("Введіть кількість рядків у масиві: ", 1);

		Console.Write("Заповнити масив випадково? (y/n): ");
		string choice = Console.ReadLine()!.Trim().ToLower();

		if (choice == "y")
		{
			Random rand = new Random();
			int[][] randomJagged = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				int cols = rand.Next(1, 5);
				randomJagged[i] = new int[cols];
				for (int j = 0; j < cols; j++)
					randomJagged[i][j] = rand.Next(-100, 101);
			}

			Console.WriteLine("Згенеровано масив:");
			PrintJaggedArray(randomJagged);
			return randomJagged;
		}
		else if(choice == "n")
		{
			int[][] jaggedArray = new int[rows][];
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
			PrintJaggedArray(jaggedArray);
			return jaggedArray;
		}
		else
		{
			Console.WriteLine("Введено некоректне значення. Повторіть спробу!");
			return InputJaggedArray();
		}
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
