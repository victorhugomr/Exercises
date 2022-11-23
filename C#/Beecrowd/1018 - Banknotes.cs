using System; 

class URI {

    static void Main(string[] args) { 
        
        int value = int.Parse(Console.ReadLine());
        int numeroNotas = 0;
        
        Console.WriteLine($"{value}");

        numeroNotas = value/100;
        value = value%100;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 100,00");
        
        numeroNotas = value/50;
        value = value%50;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 50,00");
        
        numeroNotas = value/20;
        value = value%20;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 20,00");

        numeroNotas = value/10;
        value = value%10;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 10,00");
        
        numeroNotas = value/5;
        value = value%5;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 5,00");
        
        numeroNotas = value/2;
        value = value%2;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 2,00");
        
        numeroNotas = value/1;
        value = value%1;

        Console.WriteLine($"{numeroNotas} nota(s) de R$ 1,00");

    }

}
