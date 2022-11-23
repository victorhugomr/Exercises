using System;

namespace Beecrowd{
    
    class URI {

        static void Main(string[] args) { 
            
				string[] scanf = Console.ReadLine().Split();
				int A = int.Parse(scanf[0]);
				int B = int.Parse(scanf[1]);
				int C = int.Parse(scanf[2]);
				int D = int.Parse(scanf[3]);
				
				if(B>C && D>A && C+D>A+B && C>0 && D>0 && A%2==0){
					Console.WriteLine("Valores aceitos");
				}
				else{
					Console.WriteLine("Valores nao aceitos");
				}
        }
    }
}
