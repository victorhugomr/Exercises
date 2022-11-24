using System;

namespace Beecrowd{

	class URI {
		static void Main(string[] args){ 

			double number = double.Parse(Console.ReadLine());
			
			if(0 <= number && number <= 100){
				if(0 <= number && number <= 25){
					Console.WriteLine("Intervalo [0,25]");
				}
				if(25 < number && number <= 50){
					Console.WriteLine("Intervalo (25,50]");
				}
				if(50 < number && number <= 75){
					Console.WriteLine("Intervalo (50,75]");
				}
				if(75 < number && number <= 100){
					Console.WriteLine("Intervalo (75,100]");
				}
			}
			else{
				Console.WriteLine("Fora de intervalo");
			}
		}
	}
}
