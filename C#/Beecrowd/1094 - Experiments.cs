using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			
			int n = int.Parse(Console.ReadLine());
			string[] animais = new string[2];
			double total = 0;
			double coelhos = 0;
			double ratos = 0;
			double sapos = 0;
			double coelhosPercentual = 0;
			double ratosPercentual = 0;
			double saposPercentual = 0;
			
			for(int i=1; i<=n; i++){
				animais = Console.ReadLine().Split().ToArray();
				
				if(animais[1] == "C"){
					coelhos += double.Parse(animais[0]);
					total += double.Parse(animais[0]);
				}
				else{
					if(animais[1] == "R"){
						ratos += double.Parse(animais[0]);
						total += double.Parse(animais[0]);
					}
					else if(animais[1] == "S"){
						sapos += double.Parse(animais[0]);
						total += double.Parse(animais[0]);
					}
				}
			}
            
			coelhosPercentual = (coelhos / total) * 100;
			ratosPercentual = (ratos / total) * 100;
			saposPercentual = (sapos / total) * 100;
			
			Console.WriteLine($"Total: {total} cobaias");
			Console.WriteLine($"Total de coelhos: {coelhos}");
			Console.WriteLine($"Total de ratos: {ratos}");
			Console.WriteLine($"Total de sapos: {sapos}");
			Console.WriteLine($"Percentual de coelhos: {coelhosPercentual:0.00} %");
			Console.WriteLine($"Percentual de ratos: {ratosPercentual:0.00} %");
			Console.WriteLine($"Percentual de sapos: {saposPercentual:0.00} %");
    	}
    }
}
