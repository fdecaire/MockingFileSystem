using System;
using MockingFileSystem;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var myObject = new MyClass();
			Console.WriteLine(myObject.MyMethod());
			Console.ReadKey();
		}
	}
}
