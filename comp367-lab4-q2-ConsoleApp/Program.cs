using UtilityLibraries;

namespace comp367_lab4_q2_ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kwok Yuk Chui");
			Console.WriteLine(StringLibrary.StartsWithUpper("Kwok Yuk Chui"));
			Console.WriteLine("\nkwok Yuk Chui");
			Console.WriteLine(StringLibrary.StartsWithUpper("kwok Yuk Chui"));
		}
	}
}
