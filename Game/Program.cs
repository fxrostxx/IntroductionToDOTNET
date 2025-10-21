using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			int x = Console.WindowWidth / 2;
			int y = Console.WindowHeight / 2;
			while (true)
			{
				if (x < 0) x = 0;
				else if (x >= Console.WindowWidth) x = Console.WindowWidth - 1;
				else if (y < 0) y = 0;
				else if (y >= Console.WindowHeight) y = Console.WindowHeight - 1;
				Console.SetCursorPosition(x, y);
				Console.Write("#");
				if (Console.KeyAvailable)
				{
					ConsoleKey key = Console.ReadKey(true).Key;
					Console.SetCursorPosition(x, y);
					Console.Write(" ");
					if (key == ConsoleKey.W || key == ConsoleKey.UpArrow) --y;
					else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow) ++y;
					else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow) --x;
					else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow) ++x;
					else return;
				}
			}
		}
	}
}
