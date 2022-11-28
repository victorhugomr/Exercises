using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		string str = "1 1 3 1 2 2 0 0";
		int[] array = str.Split(' ').Select(int.Parse).ToArray(); 
		
		for(int i=0;i<array.Length;i++)
 		{
  			Console.WriteLine(array[i]);
 		}
	}
}
