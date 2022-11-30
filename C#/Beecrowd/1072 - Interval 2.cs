using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int n = int.Parse(Console.ReadLine());
			int inInterval = 0;
			int outInterval = 0;
			int[] numbers = new int[n];
			
			for(int i=0; i<n; i++){
				numbers[i] = int.Parse(Console.ReadLine());
				if(numbers[i]>=10 && numbers[i]<=20){
					inInterval += 1;
				}
				else{
					outInterval += 1;
				}
			}
			Console.WriteLine($"{inInterval} in");
			Console.WriteLine($"{outInterval} out");
    	}
    }
}
