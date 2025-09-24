using System;

public class Class1
{
	public Class1()
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
}

class Program
{
	static void Main()
	{
		Class1 c = new Class1
		{
			Name = "Uday",
			Age = 23
		};

		Console.WriteLine($"Your name is {Name}, age is {Age}")
	}
}
