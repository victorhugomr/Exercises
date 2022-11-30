using System;

namespace Beecrowd{

    public class Program{
        
        static int checkLength(double[] numbers){
            int tamanho = 0;
            
			for(int i=0; i<numbers.Length; i++){
				numbers[i] = double.Parse(Console.ReadLine());
				if(numbers[i]>0)
				    tamanho += 1;
			}
			return tamanho;
		}
        
    	public static void Main(){
    		
    		double[] numbers = new double[6];
			double[] positiveNumbers = new double[checkLength(numbers)];
			double average = 0;
			int j=0;
			
			for(int i=0; i<numbers.Length; i++){
				if(numbers[i]>0){
				    positiveNumbers[j] = numbers[i];
				    j++;
				}
			}
			
			for(int i=0; i<positiveNumbers.Length; i++){
				average = average + positiveNumbers[i];
			}
			
			average = average/positiveNumbers.Length;
			
			Console.WriteLine($"{positiveNumbers.Length} valores positivos");
			Console.WriteLine($"{average:0.0}");
    	}
    }
}
