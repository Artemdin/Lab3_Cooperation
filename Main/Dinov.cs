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
		Console.WriteLine("���������� �������� 1 �������� ĳ��� �����");
		// ����� ��� �������� 1
	}

	private static void Task2()
	{
		Console.WriteLine("���������� �������� 2 �������� ĳ��� �����");
		// ����� ��� �������� 2
	}
}
