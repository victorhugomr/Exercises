using System; 

class URI {

    static void Main(string[] args) { 
        
        double A = 0;
        double B = 0;
        double C = 0;
        double pi = 3.14159D;
        double TRIANGULO = 0;
        double CIRCULO = 0;
        double TRAPEZIO = 0;
        double QUADRADO = 0;
        double RETANGULO = 0;
        string[] scanf = Console.ReadLine().Split();
        
        A = double.Parse(scanf[0]);
        B = double.Parse(scanf[1]);
        C = double.Parse(scanf[2]);
        
        TRIANGULO = (A*C)/2;
        CIRCULO = pi*(C*C);
        TRAPEZIO = 0.5*C*(A+B);
        QUADRADO = B*B;
        RETANGULO = A*B;
        
        Console.WriteLine("TRIANGULO: " + String.Format("{0:0.000}", TRIANGULO));
        Console.WriteLine("CIRCULO: " + String.Format("{0:0.000}", CIRCULO));
        Console.WriteLine("TRAPEZIO: " + String.Format("{0:0.000}", TRAPEZIO));
        Console.WriteLine("QUADRADO: " + String.Format("{0:0.000}", QUADRADO));
        Console.WriteLine("RETANGULO: " + String.Format("{0:0.000}", RETANGULO));

    }

}
