using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
			string coluna1 = Console.ReadLine();
			string coluna2 = Console.ReadLine();
			string coluna3 = Console.ReadLine();
            
    		if(coluna1 == "vertebrado"){
    		    if(coluna2 == "ave"){
    		        if(coluna3 == "carnivoro"){
    		            Console.WriteLine("aguia");
        		    }
        		    else if(coluna3 == "onivoro"){
        		        Console.WriteLine("pomba");
        		    }
    		    }
    		    else if(coluna2 == "mamifero"){
    		        if(coluna3 == "onivoro"){
    		            Console.WriteLine("homem");
        		    }
        		    else if(coluna3 == "herbivoro"){
        		        Console.WriteLine("vaca");
        		    }
    		    }
    		}
    		else if(coluna1 == "invertebrado"){
    		    if(coluna2 == "inseto"){
    		        if(coluna3 == "hematofago"){
    		            Console.WriteLine("pulga");
        		    }
        		    else if(coluna3 == "herbivoro"){
        		        Console.WriteLine("lagarta");
        		    }
    		    }
    		    else if(coluna2 == "anelideo"){
    		        if(coluna3 == "hematofago"){
    		            Console.WriteLine("sanguessuga");
        		    }
        		    else if(coluna3 == "onivoro"){
        		        Console.WriteLine("minhoca");
        		    }
    		    }
    		}
    	}
    }
}
