using System;
class part03
{
	static void Main()
	{
		string s;
		int sum;
		int a, b;

		Console.WriteLine("�����Z���s���܂��B");
		Console.WriteLine("����1�B");
		s = Console.ReadLine();
		if (Int32.TryParse(s, out a))
		{
			Console.WriteLine("����1�B�́A{0}�ł�",a);
		}
		
		Console.WriteLine("����2�B");
		s = Console.ReadLine();
		if (Int32.TryParse(s, out b))
		{
			Console.WriteLine("����2�B�́A{0}�ł�", b);
		}
		sum = a + b;
		Console.WriteLine("{0} + {1} = {2}�ł�", a, b, sum);
		Console.ReadLine();
	}
}