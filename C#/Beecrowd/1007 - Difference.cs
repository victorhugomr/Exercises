using System; 

class URI {

    static void Main(string[] args) { 
        
        int DIFERENCA = 0;
        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        
        DIFERENCA = A * B - C * D;
        
        Console.WriteLine($"DIFERENCA = {DIFERENCA}");

    }

}
