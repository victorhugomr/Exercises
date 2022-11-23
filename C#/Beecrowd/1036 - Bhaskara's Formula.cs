using System;

namespace Beecrowd{
    
    class URI {

       static void Main(string[] args) { 
            
          string[] scanf = Console.ReadLine().Split();
          double a = double.Parse(scanf[0])/10;
          double b = double.Parse(scanf[1])/10;
          double c = double.Parse(scanf[2])/10;
          double delta = b*b - 4*a*c;
          double x1 = (b*(-1) + Math.Sqrt(delta))/(2*a);
          double x2 = (b*(-1) - Math.Sqrt(delta))/(2*a);

          if(a>0 && delta>=0){
            Console.WriteLine($"R1 = {x1:0.00000}");
            Console.WriteLine($"R2 = {x2:0.00000}");
          }
          else{
            Console.WriteLine("Impossivel calcular");
          }
       }
    }
}
