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
				Console.WriteLine("Невідоме завдання.");
				break;
		}
	}

	private static void Task1()
	{
		Console.WriteLine("Виконується завдання 1 студента Дінов Артем");
		// Логіка для завдання 1
	}

	private static void Task2()
	{
		Console.WriteLine("Виконується завдання 2 студента Дінов Артем");
		// Логіка для завдання 2
	}
}
