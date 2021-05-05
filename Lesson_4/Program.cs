using System;

namespace Lesson_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите массив чисел, разделённых пробелом:");
			int sum = StringNumberSum(Console.ReadLine());
			Console.WriteLine($"Сумма введённых Вами чисел равна: {sum}");
			Console.ReadLine();
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
	}
}
