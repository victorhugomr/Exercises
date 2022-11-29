using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		double[] lados = Console.ReadLine().Split().Select(double.Parse).ToArray();
    		int tamanho = lados.Length;
    		double [] ladosOrdenados = new double[tamanho];
    		
    		Array.Copy(lados, 0, ladosOrdenados, 0, tamanho);
    		Array.Sort(ladosOrdenados);
			Array.Reverse(ladosOrdenados);
    		
    		if(ladosOrdenados[0] >= ladosOrdenados[1]+ladosOrdenados[2]){
				Console.WriteLine("NAO FORMA TRIANGULO");
			}
			else{
				if(ladosOrdenados[0]*ladosOrdenados[0] == (ladosOrdenados[1]*ladosOrdenados[1])+(ladosOrdenados[2]*ladosOrdenados[2]))
					Console.WriteLine("TRIANGULO RETANGULO");

				if(ladosOrdenados[0]*ladosOrdenados[0] > (ladosOrdenados[1]*ladosOrdenados[1])+(ladosOrdenados[2]*ladosOrdenados[2]))
					Console.WriteLine("TRIANGULO OBTUSANGULO");

				if(ladosOrdenados[0]*ladosOrdenados[0] < (ladosOrdenados[1]*ladosOrdenados[1])+(ladosOrdenados[2]*ladosOrdenados[2]))
					Console.WriteLine("TRIANGULO ACUTANGULO");

				if(ladosOrdenados[0] == ladosOrdenados[1] && ladosOrdenados[1] == ladosOrdenados[2])
					Console.WriteLine("TRIANGULO EQUILATERO");

				if((ladosOrdenados[0] == ladosOrdenados[1] && ladosOrdenados[0] != ladosOrdenados[2]) || (ladosOrdenados[0] == ladosOrdenados[2] && ladosOrdenados[0] != ladosOrdenados[1]) || (ladosOrdenados[1] == ladosOrdenados[2] && ladosOrdenados[1] != ladosOrdenados[0]))
					Console.WriteLine("TRIANGULO ISOSCELES");
			}
    	}
    }
}
