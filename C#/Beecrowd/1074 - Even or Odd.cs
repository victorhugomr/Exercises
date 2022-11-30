using System;

namespace Beecrowd{

    public class Program{
		
    	public static void Main(){
    		
    		int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			
			for(int i=0; i<n; i++){
				numbers[i] = int.Parse(Console.ReadLine());
				if(numbers[i]%2==0 && numbers[i]>0){
					Console.WriteLine("EVEN POSITIVE");
				}
				else{
					if(numbers[i]%2==0 && numbers[i]<0){
						Console.WriteLine("EVEN NEGATIVE");
					}
					else{
						if(numbers[i]%2!=0 && numbers[i]>0){
							Console.WriteLine("ODD POSITIVE");
						}
						else{
							if(numbers[i]%2!=0 && numbers[i]<0){
								Console.WriteLine("ODD NEGATIVE");
							}
							else{
								Console.WriteLine("NULL");
							}
						}
					}
				}
			}
    	}
    }
}
