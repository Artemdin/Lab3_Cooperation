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
				Console.WriteLine("Невідоме завдання.");
				break;
		}
	}

	private static void Task1()
	{
		Console.WriteLine("Виконується завдання 1 студента Пальонний Назар");

		Console.WriteLine("1");
		// Логіка для завдання 1(робота з масивами)
	}

	private static void Task2()
	{
		Console.WriteLine("Виконується завдання 2 студента Пальонний Назар");

		// Логіка для завдання 2(зубчасті масиви)
	}
}
