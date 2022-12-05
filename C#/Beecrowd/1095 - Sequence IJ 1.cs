using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int letraI = 1;
			int letraJ = 60;
			
			while(letraJ>=0){
				Console.WriteLine($"I={letraI} J={letraJ}");
				letraI += 3;
				letraJ -= 5;
			}
    	}
    }
}
