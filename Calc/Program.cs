//#define CALC_IF
//#define CALC_SWITCH

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		private static string expr;
		private static readonly char[] operators = new char[] { '+', '-', '*', '/' };
		private static string[] operands;
		private static double[] values;
		private static readonly char[] digits = "0123456789.".ToCharArray();
		private static string[] operations;
		static void Main(string[] args)
		{
			//while (true)
			{
				Console.Write("Введите арифметическое выражение: ");
				//string expr = Console.ReadLine();
				//expr = "5+(1+ (2 +(22+3) *2+(33 - 44 )) /( 2+8)* 3+1)*2 - 2";
				expr = "22+33 - 44 / 2+8* 3";
				expr = expr.Replace(" ", "");
				operands = expr.Split(operators);
				values = new double[operands.Length];
				for (int i = 0; i < operands.Length; ++i) values[i] = Convert.ToDouble(operands[i]);
				operations = expr.Split(digits);
				operations = operations.Where(operation => operation != "").ToArray();
				Console.WriteLine(Calculate(expr));
#if CALC_IF
				if (expr.Contains("+")) Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}");
				else if (expr.Contains("-")) Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}");
				else if (expr.Contains("*")) Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}");
				else if (expr.Contains("/")) Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}");
				else Console.WriteLine("Error"); 
#endif
#if CALC_SWITCH
				switch (expr[expr.IndexOfAny(operators)])
				{
					case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}"); break;
					case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
					case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
					case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break;
				} 
#endif
			}
		}
		static double Calculate(string expr)
		{
			while (operations[0] != "")
			{
				for (int i = 0; i < operations.Length; ++i)
				{
					if (operations[i] == "*" || operations[i] == "/")
					{
						if (operations[i] == "*") values[i] *= values[i + 1];
						else values[i] /= values[i + 1];
						Shift(i--);
					}
				}
				for (int i = 0; i < operations.Length; ++i)
				{
					if (operations[i] == "+" || operations[i] == "-")
					{
						if (operations[i] == "+") values[i] += values[i + 1];
						else values[i] -= values[i + 1];
						Shift(i--);
					}
				}
			}
			return values[0];
		}
		static void Shift(int index)
		{
			for (int i = index; i < operations.Length - 1; ++i) operations[i] = operations[i + 1];
			for (int i = index + 1; i < values.Length - 1; ++i) values[i] = values[i + 1];
			operations[operations.Length - 1] = "";
			values[values.Length - 1] = 0;
		}
	}
}