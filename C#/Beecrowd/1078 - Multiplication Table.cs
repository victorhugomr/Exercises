using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int n = int.Parse(Console.ReadLine());
			int result = 0;
			
			for(int i=1; i<=10; i++){
				result = i * n;
				Console.WriteLine($"{i} x {n} = {result}");
			}
    	}
    }
}
