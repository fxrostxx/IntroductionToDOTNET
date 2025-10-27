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
		static void Main(string[] args)
		{
			//while (true)
			{
				Console.Write("Введите арифметическое выражение: ");
				//string expr = Console.ReadLine();
				string expr = "22+33 - 44 / 2+8* 3";
				expr = expr.Replace(" ", "");
				Console.WriteLine(expr);
				char[] operators = new char[] { '+', '-', '*', '/' };
				string[] operands = expr.Split(operators);
				double[] values = new double[operands.Length];
				char[] digits = "0123456789.".ToCharArray();
				string[] operations = expr.Split(digits);
				operations = operations.Where(operation => operation != "").ToArray();
				for (int i = 0; i < operands.Length; ++i)
				{
					values[i] = Convert.ToDouble(operands[i]);
					Console.Write($"{values[i]}\t");
				}
				Console.WriteLine();
				for (int i = 0; i < operations.Length; ++i) Console.Write($"{operations[i]}\t");
				Console.WriteLine();
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
	}
}