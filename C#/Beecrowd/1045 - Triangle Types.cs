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
    		
    		if(lados[0] >= lados[1]+lados[2])
				Console.WriteLine("NAO FORMA TRIANGULO");
			
			if(lados[0]*lados[0] == (lados[1]*lados[1])+(lados[2]*lados[2]))
				Console.WriteLine("TRIANGULO RETANGULO");
			
			if(lados[0]*lados[0] > (lados[1]*lados[1])+(lados[2]*lados[2]))
				Console.WriteLine("TRIANGULO OBTUSANGULO");
			
			if(lados[0]*lados[0] < (lados[1]*lados[1])+(lados[2]*lados[2]))
				Console.WriteLine("TRIANGULO ACUTANGULO");
			
			if(lados[0] == lados[1] && lados[1] == lados[2])
				Console.WriteLine("TRIANGULO EQUILATERO");
			
			if(lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
				Console.WriteLine("TRIANGULO ISOSCELES");
    	}
    }
}
