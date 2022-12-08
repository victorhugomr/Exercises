using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			int menu = 1;
			int grenais = 0;
			int gremio = 0;
			int internacional = 0;
			int empate = 0;
			
			do{
				int[] placar = Console.ReadLine().Split().Select(int.Parse).ToArray();
				
				if(placar[0] > placar[1]){
					internacional += 1;
				}
				else if(placar[0] < placar[1]){
					gremio += 1;
				}
				else if(placar[0] == placar[1]){
					empate += 1;
				}
				
				grenais += 1;
				
				do{
					Console.WriteLine("Novo grenal (1-sim 2-nao)");
					menu = int.Parse(Console.ReadLine());
				}while(menu != 1 && menu != 2);
				
			}while(menu == 1);
			
			Console.WriteLine("{0} grenais", grenais);
			Console.WriteLine("Inter:{0}", internacional);
			Console.WriteLine("Gremio:{0}", gremio);
			Console.WriteLine("Empates:{0}", empate);
			
			if(gremio > internacional){
				Console.WriteLine("Gremio venceu mais");
			}
			else if(gremio < internacional){
				Console.WriteLine("Inter venceu mais");
			}
    	}
    }
}
