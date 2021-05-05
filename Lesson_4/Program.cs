using System;

namespace Lesson_4
{
	enum Season
	{
		None,
		Winter,
		Spring,
		Summer,
		Autumn
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите номер месяца:");

			var month = Console.ReadLine();
			while(GetSeason(month) == Season.None)
				month = Console.ReadLine();

			Console.WriteLine($"Порядковый номер месяца ({month}) соответствует времени года {GetStringSeason(GetSeason(month))}");
			Console.ReadLine();
		}

		static Season GetSeason(string month)
		{
			switch (month)
			{
				case "1":
				case "2":
				case "12":
					return Season.Winter;

				case "3":
				case "4":
				case "5":
					return Season.Spring;

				case "6":
				case "7":
				case "8":
					return Season.Summer;

				case "9":
				case "10":
				case "11":
					return Season.Autumn;

				default:
					Console.WriteLine("Ошибка: введите число от 1 до 12");
					return Season.None;
			}
		}
		static string GetStringSeason(Season season)
		{
			switch (season)
			{
				case Season.Winter:
					return "Зима";

				case Season.Spring:
					return "Весна";

				case Season.Summer:
					return "Лето";

				case Season.Autumn:
					return "Осень";

				default:
					return "Ошибка: введите число от 1 до 12";
			}
		}
	}
}
