using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int[] scanf = Console.ReadLine().Split().Select(int.Parse).ToArray();
    		
    		if((scanf[1] % scanf[0]) == 0){
				Console.WriteLine("Sao Multiplos");
			}
			else{
				Console.WriteLine("Nao sao Multiplos");
			}
    	}
    }
}
