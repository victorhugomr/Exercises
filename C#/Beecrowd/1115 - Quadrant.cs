using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
			int[] coordenadas = new int[2];
			coordenadas = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int x = coordenadas[0];
			int y = coordenadas[1];

			while(x!=0 && y!=0){
				if(x>0){
					if(y>0){
						Console.WriteLine("primeiro");
					}
					else{
						if(y<0){
							Console.WriteLine("quarto");
						}
					}
				}
				else{
					if(x<0){
						if(y>0){
							Console.WriteLine("segundo");
						}
						else{
							if(y<0){
								Console.WriteLine("terceiro");
							}
						}
					}
				}
				
				coordenadas = Console.ReadLine().Split().Select(int.Parse).ToArray();
				x = coordenadas[0];
				y = coordenadas[1];
			}
		}
	}
}
