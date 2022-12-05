using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int letraI = 1;
			int letraJ = 7;
			
			while(letraI<=9){
				Console.WriteLine($"I={letraI} J={letraJ}");
				if(letraJ==5){
				    letraI += 2;
				    letraJ = 7;
				}
				else{
				    letraJ -= 1;
				}
			}
    	}
    }
}
