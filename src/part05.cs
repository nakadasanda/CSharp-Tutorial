using System;
class part03
{
	static void Main()
	{
		string s;
		int sum;
		int a, b;

		Console.WriteLine("足し算を行います。");
		Console.WriteLine("数字1。");
		s = Console.ReadLine();
		if (Int32.TryParse(s, out a))
		{
			Console.WriteLine("数字1。は、{0}です",a);
		}
		
		Console.WriteLine("数字2。");
		s = Console.ReadLine();
		if (Int32.TryParse(s, out b))
		{
			Console.WriteLine("数字2。は、{0}です", b);
		}
		sum = a + b;
		Console.WriteLine("{0} + {1} = {2}です", a, b, sum);
		Console.ReadLine();
	}
}