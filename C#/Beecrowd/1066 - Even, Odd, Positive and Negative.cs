using System;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int[] numbers = new int[5];
			int countEven = 0;
			int countOdd = 0;
			int countPositives = 0;
			int countNegatives = 0;
			
			for(int i=0; i<numbers.Length; i++){
				numbers[i] = int.Parse(Console.ReadLine());
				if(numbers[i]%2 == 0)
				    countEven += 1;
				else if(numbers[i]%2 != 0)
					countOdd += 1;
				if(numbers[i] > 0)
					countPositives += 1;
				else if(numbers[i] < 0)
					countNegatives += 1;
			}
			
			Console.WriteLine($"{countEven} valor(es) par(es)");
			Console.WriteLine($"{countOdd} valor(es) impar(es)");
			Console.WriteLine($"{countPositives} valor(es) positivo(s)");
			Console.WriteLine($"{countNegatives} valor(es) negativo(s)");
    	}
    }
}
