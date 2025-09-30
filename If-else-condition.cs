//Simple program using if-else-statement (branching conditions)
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Choose two numbers");
		int x,y;
		x=Int16.Parse(Console.ReadLine());
		y=Int16.Parse(Console.ReadLine());
		
		if (x>y){
			 Console.WriteLine($"{x} is greater than {y}");
		}
		else if (x<y){
			Console.WriteLine($"{x} is less than {y}");
		}
		else {
			Console.WriteLine($"{x} and {y} are equal");
		}
	}
}