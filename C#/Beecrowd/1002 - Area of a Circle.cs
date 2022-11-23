using System; 

class URI {

    static void Main(string[] args) { 
        
        double A = 0;
        double n = 3.14159;
        double R = double.Parse(Console.ReadLine());
        
        A = n*(R*R);
        
        Console.WriteLine("A=" + String.Format("{0:0.0000}", A));

    }

}
