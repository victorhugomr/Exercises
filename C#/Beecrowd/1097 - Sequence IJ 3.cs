using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int letraI = 1;
			int letraJ = 7;
			int count = 0;
			
			while(letraI<=9){
				Console.WriteLine($"I={letraI} J={letraJ}");
				if(count==2){
				    letraI += 2;
				    letraJ += 4;
				    count = 0;
				}
				else{
				    letraJ -= 1;
				    count += 1;
				}
			}
    	}
    }
}
