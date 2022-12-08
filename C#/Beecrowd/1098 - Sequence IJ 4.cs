using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		double i = 0;
			double j = 1;
			int count = 1;
			
			do{
				if(count <= 3){
					j += i;
					if(j%1.0 != 0){
						Console.WriteLine("I={0} J={1:0.0}", i, j);
					}
					else if(j%1.0 == 0){
						Console.WriteLine("I={0} J={1}", i, j);
					}
					j -= i;
					j++;
					count++;
				}
				else if (count > 3){
					j = 1;
					count = 1;
					i += 0.2;
				}
			}while(i <= 2);
			
    	}
    }
}
