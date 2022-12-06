using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
    		int[] numbers = new int[2];
			int sum = 0;
			int aux = 0;
			int n = int.Parse(Console.ReadLine());
			
			for(int i=0; i<n; i++){
				numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
				
				if(numbers[0] > numbers[1]){
    				aux = numbers[1];
    				numbers[1] = numbers[0];
    				numbers[0] = aux;
			    }
                
                for(int j=numbers[0]; j<numbers[1]; j++){
                    if(j==numbers[0] && j%2 == 1){
						j += 1;
                    }
					else if(j%2 == 1){
                        sum += j;
					}
                }
                
				Console.WriteLine(sum);
				sum = 0;
			}
    	}
    }
}
