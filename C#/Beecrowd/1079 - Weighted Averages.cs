using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
    		double[] numbers = new double[3];
			double average = 0;
			int n = int.Parse(Console.ReadLine());
			
			for(int i=1; i<=n; i++){
				numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
				average = (numbers[0]*2 + numbers[1]*3 + numbers[2]*5)/10;
				Console.WriteLine($"{average:0.0}");
			}
    	}
    }
}
