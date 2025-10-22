using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Введите выражение (exit для выхода): ");
				string expr = Console.ReadLine();
				if (expr == "exit") break;
				string[] parts = expr.Split(' ');
				try
				{
					switch (Convert.ToChar(parts[1]))
					{
						case '+': Console.WriteLine(Convert.ToDouble(parts[0]) + Convert.ToDouble(parts[2])); break;
						case '-': Console.WriteLine(Convert.ToDouble(parts[0]) - Convert.ToDouble(parts[2])); break;
						case '*': Console.WriteLine(Convert.ToDouble(parts[0]) * Convert.ToDouble(parts[2])); break;
						case '/': Console.WriteLine(Convert.ToDouble(parts[0]) / Convert.ToDouble(parts[2])); break;
						default: Console.WriteLine("Ошибка: неизвестный оператор"); break;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("Ошибка: проверьте корректность выражения");
				}
			}
		}
	}
}
