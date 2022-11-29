using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int[] scanf = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int initialHour = scanf[0];
			int initialMinute = scanf[1];
			int finalHour = scanf[2];
			int finalMinute = scanf[3];
			int gameHour = 0;
			int gameMinute = 0;
    		
			gameMinute = finalMinute - initialMinute;

			if(gameMinute < 0){
				gameMinute = 60 - gameMinute*(-1);
				finalHour = finalHour - 1;
			}
			
		    gameHour = finalHour - initialHour;
			
			if(gameHour == 0 && gameMinute == 0){
				Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
			}
			else{
				if(gameHour < 0){
					gameHour = 24 - gameHour*(-1);
				}
				Console.WriteLine($"O JOGO DUROU {gameHour} HORA(S) E {gameMinute} MINUTO(S)");
			}
    	}
    }
}
