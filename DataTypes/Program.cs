#define DATA_TYPES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimeter = "\n----------------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} байт памяти, класс-обвертка {typeof(bool)}");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(delimeter);

			Console.WriteLine($"char занимает {sizeof(char)} байта памяти и принимает значения в диапазоне от {(int)char.MinValue} до {(int)char.MaxValue}, класс-обвертка {typeof(char)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"sbyte занимает {sizeof(sbyte)} байт памяти и принимает значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue}, класс-обвертка {typeof(sbyte)}");
			Console.WriteLine($"byte занимает {sizeof(byte)} байт памяти и принимает значения в диапазоне от {byte.MinValue} до {byte.MaxValue}, класс-обвертка {typeof(byte)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"short занимает {sizeof(short)} байта памяти и принимает значения в диапазоне от {short.MinValue} до {short.MaxValue}, класс-обвертка {typeof(short)}");
			Console.WriteLine($"ushort занимает {sizeof(ushort)} байта памяти и принимает значения в диапазоне от {ushort.MinValue} до {ushort.MaxValue}, класс-обвертка {typeof(ushort)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"int занимает {sizeof(int)} байта памяти и принимает значения в диапазоне от {int.MinValue} до {int.MaxValue}, класс-обвертка {typeof(int)}");
			Console.WriteLine($"uint занимает {sizeof(uint)} байта памяти и принимает значения в диапазоне от {uint.MinValue} до {uint.MaxValue}, класс-обвертка {typeof(uint)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"long занимает {sizeof(long)} байт памяти и принимает значения в диапазоне от {long.MinValue} до {long.MaxValue}, класс-обвертка {typeof(long)}");
			Console.WriteLine($"ulong занимает {sizeof(ulong)} байт памяти и принимает значения в диапазоне от {ulong.MinValue} до {ulong.MaxValue}, класс-обвертка {typeof(ulong)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"float занимает {sizeof(float)} байта памяти и принимает значения в диапазоне от {float.MinValue} до {float.MaxValue}, класс-обвертка {typeof(float)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"double занимает {sizeof(double)} байт памяти и принимает значения в диапазоне от {double.MinValue} до {double.MaxValue}, класс-обвертка {typeof(double)}");
			Console.WriteLine(delimeter);

			Console.WriteLine($"decimal занимает {sizeof(decimal)} байт памяти и принимает значения в диапазоне от {decimal.MinValue} до {decimal.MaxValue}, класс-обвертка {typeof(decimal)}");
			Console.WriteLine(delimeter);
#endif
		}
	}
}
