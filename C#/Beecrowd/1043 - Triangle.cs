using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
		static bool checkValidity(double a, double b, double c){
			if (a + b <= c || a + c <= b || b + c <= a){
				return false;
			}
			else{
				return true;
			}
		}
		
    	public static void Main(){
    		
    		double[] scanf = Console.ReadLine().Split().Select(double.Parse).ToArray();
			double triangulo = scanf[0] + scanf[1] + scanf[2];
			double trapezio = ((scanf[0]+scanf[1]) * scanf[2])/2;
    		
    		if(checkValidity(scanf[0], scanf[1], scanf[2])){
				Console.WriteLine($"Perimetro = {triangulo:0.0}");
			}
			else{
				Console.WriteLine($"Area = {trapezio:0.0}");
			}
    	}
    }
}
