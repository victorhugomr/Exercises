using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
    		int[] numbers = new int[100];
			
			for(int i=0; i<100; i++){
				numbers[i] = int.Parse(Console.ReadLine());
			}
			
			int maxValue = numbers.Max();
 			int maxIndex = numbers.ToList().IndexOf(maxValue) + 1;
			
			Console.WriteLine(maxValue);
			Console.WriteLine(maxIndex);
    	}
    }
}
