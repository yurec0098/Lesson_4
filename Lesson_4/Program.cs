using System;

namespace Lesson_4
{
	class Program
	{
		static void Main(string[] args)
		{
			int result = 0;
			var pos = Console.GetCursorPosition();
			pos.Top++;
			Console.WriteLine("Расчёт Числа Фибоначчи");
			do
			{
				ClearConsoleLines(pos.Left, pos.Top, 2);

				int n = ReadInt("Введите число (от -40 до 40):", -40, 40);
				if (n >= 0)
					result = Fibonacci(n);
				else
					result = FibonacciNegative(n);

				Console.WriteLine($"Число Фибоначчи для n = {n} составило {result}");
				Console.WriteLine();
				pos = Console.GetCursorPosition();


				Console.WriteLine("Попробуем ещё? Тогда введите +");
			} while (Console.ReadLine() == "+");
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
