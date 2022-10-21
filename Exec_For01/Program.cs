using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int length = 10; length >= 1; length--)
			{
				Console.WriteLine(new string('*', length));
			}
		}
	}
}
