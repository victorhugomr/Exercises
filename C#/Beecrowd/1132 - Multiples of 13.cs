using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			int aux = 0;
			int sum = 0;
			
			if(x > y){
				aux = x;
				x = y;
				y = aux;
			}
    		
			for(int i=x; i<=y; i++){
				if(i%13 != 0){
					sum += i;
				}
			}
			
			Console.WriteLine(sum);
			
    	}
    }
}
