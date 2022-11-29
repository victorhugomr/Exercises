using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		double[] numbers = new double[6];
			int positiveNumbers = 0;
			
    		for(int i=0; i<numbers.Length; i++){
				numbers[i] = double.Parse(Console.ReadLine());
				if(numbers[i]>0)
				    positiveNumbers += 1;
			}
			
			Console.WriteLine($"{positiveNumbers} valores positivos");
			
    	}
    }
}
