using System;

namespace Lesson_4
{
	class Program
	{
		enum Season
		{
			None,
			Winter,
			Spring,
			Summer,
			Autumn
		}

		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();
				WriteLineCentr("Добро пожаловать!", 30);
				WriteLineCentr("Выберите чем займёмся:", 30);
				Console.WriteLine();
				Console.WriteLine("  1. Вывод ФИО");
				Console.WriteLine("  2. Сумма чисел из массива");
				Console.WriteLine("  3. Сезон года");
				Console.WriteLine("  4. Фибоначчи");
				Console.WriteLine();
				Console.WriteLine("  0. Выход");

				string line = Console.ReadLine();
				Console.Clear();
				switch (line)
				{
					case "1":
						RunFullNames(); break;
					case "2":
						RunStringSum(); break;
					case "3":
						RunSeason(); break;
					case "4":
						RunFibonacci(); break;

					case "0":
						return;

					default:
						break;
				}

				Console.ReadLine();
			}

			static void WriteLineCentr(string text, int max = 40)
			{
				int startPos = (max - text.Length) / 2;
				Console.SetCursorPosition(startPos, Console.CursorTop);
				Console.WriteLine($"{text}");
			}


			static void RunFullNames()
			{
				WriteLineCentr("Вывод ФИО", 30);

				Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
				Console.WriteLine(GetFullName("Сидоров", "Пётр", "Николаевич"));
				Console.WriteLine(GetFullName("Крюкова", "Ольга", "Петровна"));
				Console.WriteLine(GetFullName("Дудник", "Андрей", "Романович"));
			}
			static string GetFullName(string firstName, string lastName, string patronymic)
			{
				return $"{firstName} {lastName} {patronymic}";
			}

			static void RunStringSum()
			{
				WriteLineCentr("Сумма чисел из массива", 30);

				Console.WriteLine("Введите массив чисел, разделённых пробелом:");
				int sum = StringNumberSum(Console.ReadLine());
				Console.WriteLine($"Сумма введённых Вами чисел равна: {sum}");
			}
			static int StringNumberSum(string numbers)
			{
				int result = 0;
				int tmp_val;

				foreach (var x in numbers.Split(' '))
					if (int.TryParse(x, out tmp_val))
						result += tmp_val;

				return result;
			}

			static void RunSeason()
			{
				WriteLineCentr("Сезон года", 30);
				Console.WriteLine("Введите номер месяца:");

				var month = Console.ReadLine();
				while (GetSeason(month) == Season.None)
					month = Console.ReadLine();

				Console.WriteLine($"Порядковый номер месяца ({month}) соответствует времени года {GetStringSeason(GetSeason(month))}");
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

			static void RunFibonacci()
			{
				int result = 0;
				WriteLineCentr("Расчёт Числа Фибоначчи", 30);

				int n = ReadInt("Введите число (от -40 до 40):", -40, 40);
				if (n >= 0)
					result = Fibonacci(n);
				else
					result = FibonacciNegative(n);

				Console.WriteLine($"Число Фибоначчи для n = {n} составило {result}");
			}
			//	F{0}=0,		F_{1}=1,	F_{n}=F_{n-1}+F_{n-2}
			static int Fibonacci(int n)
			{
				if (n == 0)
					return 0;
				if (n == 1)
					return 1;

				return Fibonacci(n - 1) + Fibonacci(n - 2);
			}
			//	F{0}=0,		F_{1}=1,	F_{n}=F_{n+2}-F_{n+1}
			static int FibonacciNegative(int n)
			{
				if (n == 0)
					return 0;
				if (n == 1)
					return 1;

				return FibonacciNegative(n + 2) - FibonacciNegative(n + 1);
			}


			static int ReadInt(string text, int min, int max)
			{
				int value;
				var pos = Console.GetCursorPosition();
				Console.WriteLine(text);
				while (!(int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max))
				{
					ClearConsoleLines(pos.Left, pos.Top, 2);
					Console.WriteLine($"Повторим... {text}");
				}

				return value;
			}
			static void ClearConsoleLines(int left, int top, int count)
			{
				Console.SetCursorPosition(left, top);

				for (int i = 0; i < count; i++)
					Console.WriteLine(new string(' ', Console.WindowWidth));

				Console.SetCursorPosition(left, top);
			}
		}
	}
}
