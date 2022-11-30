using System;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int[] numbers = new int[5];
			int evenNumbers = 0;
			
			for(int i=0; i<numbers.Length; i++){
				numbers[i] = int.Parse(Console.ReadLine());
				if(numbers[i]%2 == 0)
				    evenNumbers += 1;
			}
			
			Console.WriteLine($"{evenNumbers} valores pares");
    	}
    }
}
