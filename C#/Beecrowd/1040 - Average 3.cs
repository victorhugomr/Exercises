using System;

namespace Beecrowd{

	class URI {
	    
		static void Main(string[] args){ 

			string[] scanf = Console.ReadLine().Split();
			double n1 = double.Parse(scanf[0]);
			double n2 = double.Parse(scanf[1]);
			double n3 = double.Parse(scanf[2]);
			double n4 = double.Parse(scanf[3]);
			double media = Math.Floor((n1*2 + n2*3 + n3*4 + n4*1)/(2+3+4+1) *100)/100;
			double notaExame = 0;
			double mediaFinal = 0;

			Console.WriteLine($"Media: {media:0.0}");

			if(media>=7){
				Console.WriteLine($"Aluno aprovado.");
			}
			else{
				if(media<=4.9){
					Console.WriteLine($"Aluno reprovado.");
				}
				else{
					Console.WriteLine($"Aluno em exame.");

					notaExame = double.Parse(Console.ReadLine());

					Console.WriteLine($"Nota do exame: {notaExame:0.0}");

					mediaFinal = (media + notaExame)/2;

					if(mediaFinal<=4.9){
						Console.WriteLine($"Aluno reprovado.");
					}
					else{
						Console.WriteLine($"Aluno aprovado.");
						Console.WriteLine($"Media final: {mediaFinal:0.0}");
					}
				}
			}
		}
	}
}
