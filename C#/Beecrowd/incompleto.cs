using System; 

class URI {

    static void Main(string[] args) { 
        
        double value = double.Parse(Console.ReadLine());
        double numeroNotas = 0;
        double numeroMoedas = 0;
        
        Console.WriteLine("NOTAS:");
        
        numeroNotas = value/100;
        value = value%100;

        Console.WriteLine($"{Math.Truncate(numeroNotas)} nota(s) de R$ 100.00");
        
        numeroNotas = value/50;
        value = value%50;

        Console.WriteLine($"{Math.Truncate(numeroNotas)} nota(s) de R$ 50.00");
        
        numeroNotas = value/20;
        value = value%20;

        Console.WriteLine($"{Math.Truncate(numeroNotas)} nota(s) de R$ 20.00");

        numeroNotas = value/10;
        value = value%10;

        Console.WriteLine($"{Math.Truncate(numeroNotas)} nota(s) de R$ 10.00");
        
        numeroNotas = value/5;
        value = value%5;

        Console.WriteLine($"{Math.Truncate(numeroNotas)} nota(s) de R$ 5.00");
        
        numeroNotas = value/2;
        value = value%2;

        Console.WriteLine($"{Math.Truncate(numeroNotas)} nota(s) de R$ 2.00");
        
        Console.WriteLine("MOEDAS:");
        
        numeroMoedas = value/1;
        value = value%1;

        Console.WriteLine($"{Math.Truncate(numeroMoedas)} moeda(s) de R$ 1.00");
        
        numeroMoedas = value/0.5;
        value = value%0.5;

        Console.WriteLine($"{Math.Truncate(numeroMoedas)} moeda(s) de R$ 0.50");
        
        numeroMoedas = value/0.25;
        value = value%0.25;

        Console.WriteLine($"{Math.Truncate(numeroMoedas)} moeda(s) de R$ 0.25");

        numeroMoedas = value/0.1;
        value = value%0.1;

        Console.WriteLine($"{Math.Truncate(numeroMoedas)} moeda(s) de R$ 0.10");
        
        numeroMoedas = value/0.05;
        value = value%0.05;

        Console.WriteLine($"{Math.Truncate(numeroMoedas)} moeda(s) de R$ 0.05");
        
        numeroMoedas = value/0.01;
        value = value%0.01;

        Console.WriteLine($"{Math.Truncate(numeroMoedas)} moeda(s) de R$ 0.01");

    }

}