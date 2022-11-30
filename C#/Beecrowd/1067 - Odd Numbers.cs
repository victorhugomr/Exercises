using System;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int number = int.Parse(Console.ReadLine());
			
			for(int i=0; i<=number; i++){
				if(i%2 != 0)
					Console.WriteLine(i);
			}
    	}
    }
}
