using System;

namespace Beecrowd{

	class URI {
	    
		static void Main(string[] args){ 

			string[] scanf = Console.ReadLine().Split();
			double x = double.Parse(scanf[0]);
			double y = double.Parse(scanf[1]);

			if(x>0){
			    if(y>0){
			        Console.WriteLine("Q1");
			    }
			    else{
			        if(y<0){
			            Console.WriteLine("Q4");
			        }
			        else{
			            Console.WriteLine("Eixo X");
			        }
			    }
			}
			else{
			    if(x<0){
			        if(y>0){
                        Console.WriteLine("Q2");
			        }
			        else{
			            if(y<0){
			                Console.WriteLine("Q3");
			            }
			            else{
                            Console.WriteLine("Eixo X");
			            }
			        }
			    }
			    else{
			        if(y==0){
			            Console.WriteLine("Origem");
			        }
			        else{
			            Console.WriteLine("Eixo Y");
			        }
			    }
			}
		}
	}
}
