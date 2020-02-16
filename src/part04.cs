using System;
class part03
{
	static void Main()
	{
		string s;
		int sum;
		int a,b;

		Console.WriteLine("足し算を行います。");
		Console.WriteLine("数字1。");
		s = Console.ReadLine();
		a = Int32.Parse(s);
		Console.WriteLine("数字2。");
		s = Console.ReadLine();
		b = Int32.Parse(s);
		sum = a + b;
		Console.WriteLine("{0} + {1} = {2}です",a,b,sum);
		Console.ReadLine();
	}
}