using System;

namespace Lesson_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
			Console.WriteLine(GetFullName("Сидоров", "Пётр", "Николаевич"));
			Console.WriteLine(GetFullName("Крюкова", "Ольга", "Петровна"));
			Console.WriteLine(GetFullName("Дудник", "Андрей", "Романович"));
		}

		static string GetFullName(string firstName, string lastName, string patronymic)
		{
			return $"{firstName} {lastName} {patronymic}";
		}
	}
}
