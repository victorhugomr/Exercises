using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
		bool checkValidity(int a, int b, int c){
			if (a + b <= c || a + c <= b || b + c <= a){
				return false;
			}
			else{
				return true;
			}
		}
		
    	public static void Main(){
    		
    		double[] scanf = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double triangulo = 0;
			double trapezio = 0;
    		
    		if(checkValidity(a, b, c)){
				Console.WriteLine("Perimetro = {triangulo}");
			}
			else{
				Console.WriteLine("Area = {trapezio}");
			}
    	}
    }
}
