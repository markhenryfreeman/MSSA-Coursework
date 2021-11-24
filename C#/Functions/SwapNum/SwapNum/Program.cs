using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNum
{
    class Program
	{
		static void SwapNum(ref int x, ref int y)
		{
			int tempswap = x;
			x = y;
			y = tempswap;
		}
		static void Main(string[] args)
		{
			int a = 10;
			int b = 5;

			Console.WriteLine("Value of a and b before swapping");
			Console.WriteLine();
			Console.WriteLine("a=" + " " + a);
			Console.WriteLine("b=" + " " + b);
			Console.WriteLine(" \n");
			SwapNum(ref a, ref b);
			Console.WriteLine("Value of a and b after sawapping");
			Console.WriteLine();
			Console.WriteLine("a=" + " " + a);
			Console.WriteLine("b=" + " " + b);
			Console.ReadLine();
		}
	}
}
