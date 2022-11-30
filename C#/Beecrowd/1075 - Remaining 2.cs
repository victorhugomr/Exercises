using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			
			for(int i=1; i<=10000; i++){
				if(i%n == 2)
					Console.WriteLine(i);
			}
    	}
    }
}
