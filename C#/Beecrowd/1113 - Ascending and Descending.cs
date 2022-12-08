using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
			int[] numbers = new int[2];
			
			numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			
			do{				
				if(numbers[0] > numbers[1]){
					Console.WriteLine("Decrescente");
				}
				else if(numbers[0] < numbers[1]){
					Console.WriteLine("Crescente");
				}

				numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
				
			}while(numbers[0] != numbers[1]);
    	}
    }
}
