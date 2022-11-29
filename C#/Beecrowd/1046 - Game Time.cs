using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int[] scanf = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int start = scanf[0];
			int end = scanf[1];
			int gameTime = 0;
    		
			if(start < end){
				gameTime = end - start;
				Console.WriteLine($"O JOGO DUROU {gameTime} HORA(S)");
			}
			else{
				if(start > end){
					gameTime = (24 - start) + end;
					Console.WriteLine($"O JOGO DUROU {gameTime} HORA(S)");
				}
				else{
					Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
				}
			}
    	}
    }
}
