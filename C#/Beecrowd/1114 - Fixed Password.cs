using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
			int password = int.Parse(Console.ReadLine());
			
			while(password != 2002){
				
				Console.WriteLine("Senha Invalida");
				
				password = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("Acesso Permitido");
    	}
    }
}
