using System; 

class URI {

    static void Main(string[] args) { 
        
        int PROD = 0;
        int A = 0;
        int B = 0;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        
        PROD = A * B;
        
        Console.WriteLine($"PROD = {PROD}");

    }

}
