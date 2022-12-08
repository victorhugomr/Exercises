using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
			int n = int.Parse(Console.ReadLine());
			double result = 0;
			
			for(int i=0; i<n; i++){
				double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
				
				if(numbers[1] == 0){
					Console.WriteLine("divisao impossivel");
				}
				else{
					result = numbers[0] / numbers[1];
					Console.WriteLine("{0:0.0}", result);
				}
			}
    	}
    }
}
