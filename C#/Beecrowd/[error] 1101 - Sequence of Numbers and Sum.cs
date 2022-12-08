using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
			int[] numbers = new int[2];
			
			numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			
			do{
				int sum = 0;
				int aux = 0;
				int countSoma = 0;
				int lengthSoma = 0;
				
				if(numbers[0] > numbers[1]){
					aux = numbers[1];
					numbers[1] = numbers[0];
					numbers[0] = aux;
				}
				
				for(int i=numbers[0]; i<=numbers[1]; i++){
					lengthSoma += 1;
				}
				
				int[] numerosSomados = new int[lengthSoma];
				
				for(int i=numbers[0]; i<=numbers[1]; i++){
					sum += i;
					numerosSomados[countSoma] = i;
					countSoma += 1;
				}
				
				Console.WriteLine("{0} Sum={1}", string.Join(" ", numerosSomados), sum);
				
				sum = 0;
				numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
				
			}while(numbers[0]!=0 && numbers[1]!=0);
    	}
    }
}
