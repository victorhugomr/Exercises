using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int n = int.Parse(Console.ReadLine());
			int evenSquare = 0;
			
			for(int i=1; i<=n; i++){
				if(i%2 == 0){
					evenSquare = i*i;
					Console.WriteLine($"{i}^2 = {evenSquare}");
				}
			}
    	}
    }
}
