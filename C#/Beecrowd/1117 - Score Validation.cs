using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
			double nota1 = double.Parse(Console.ReadLine());
			double media = 0;
			
			while(nota1 < 0 || nota1 > 10){
				Console.WriteLine("nota invalida");
				nota1 = double.Parse(Console.ReadLine());
			}
			
			double nota2 = double.Parse(Console.ReadLine());
			
			while(nota2 < 0 || nota2 > 10){
				Console.WriteLine("nota invalida");
				nota2 = double.Parse(Console.ReadLine());
			}
			
			media = (nota1 + nota2) / 2;
			
			Console.WriteLine("media = {0:0.00}", media);
    	}
    }
}
