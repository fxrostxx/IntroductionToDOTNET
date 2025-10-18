//#define CONSOLE
//#dfeine IO
#define GEOMETRY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.Write("Hello World!\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello .NET");
            Console.Title = "Introduction to .NET";
            Console.Beep(300, 100);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetConsoleCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("AnotherConsoleCursorPosition");
            Console.ResetColor(); 
#endif

#if IO
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите вашу фамилию: ");
			string last_name = Console.ReadLine();
			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(last_name + " " + first_name + " " + age);
			Console.WriteLine(String.Format("{0} {1} {2}", last_name, first_name, age));
			Console.WriteLine($"{last_name} {first_name} {age}");   // Интерполяция строк  
#endif

#if GEOMETRY
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j) Console.Write(j <= i ? "* " : "");
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j) Console.Write(j >= i ? "* " : "");
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j) Console.Write(j >= i ? "* " : "  ");
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j) Console.Write(j >= n - i - 1 ? "* " : "  ");
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n - i - 1; ++j) Console.Write(" ");
				Console.Write("/");
				for (int j = 0; j < i * 2; j++) Console.Write(" ");
				Console.WriteLine("\\");
			}
			for (int i = n - 1; i >= 0; --i)
			{
				for (int j = 0; j < n - i - 1; ++j) Console.Write(" ");
				Console.Write("\\");
				for (int j = 0; j < i * 2; ++j) Console.Write(" ");
				Console.WriteLine("/");
			}
			Console.WriteLine();
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < n; ++j) Console.Write(i % 2 == 0 ? (j % 2 == 0 ? "+ " : "- ") : (j % 2 != 0 ? "+ " : "- "));
				Console.WriteLine();
			}
#endif
		}
	}
}