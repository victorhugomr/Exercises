using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
    		int[] numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    		int tamanho = numeros.Length;
    		int [] numerosOrdenados = new int[tamanho];
    		
    		Array.Copy(numeros, 0, numerosOrdenados, 0, tamanho);
    		Array.Sort(numerosOrdenados);
    		
    		for(int i=0;i<numeros.Length;i++){
      			Console.WriteLine(numerosOrdenados[i]);
    		}
			
			Console.WriteLine();
			
    		for(int i=0;i<numeros.Length;i++){
      			Console.WriteLine(numeros[i]);
     		}
    	}
    }
}
