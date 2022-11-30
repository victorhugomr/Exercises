using System;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int number = int.Parse(Console.ReadLine());
			
			for(int i=0; i<6;){
				if(number%2 != 0){
					Console.WriteLine(number);
					number += 1;
				    i += 1;
				}
				else{
					number += 1;
				}
			}
    	}
    }
}
