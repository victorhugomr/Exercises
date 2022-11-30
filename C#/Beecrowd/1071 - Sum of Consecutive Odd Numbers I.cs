using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			int sumOdds = 0;
			int aux = 0;
			
			if(y > x){
				aux = x;
				x = y;
				y = aux;
			}
			
			for(int i=y+1; i<x; i++){
				if(i%2 != 0){
					sumOdds = sumOdds + i;
				}
			}
			Console.WriteLine(sumOdds);
    	}
    }
}
