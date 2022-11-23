using System; 

class URI {

    static void Main(string[] args) { 
        
        double pi = 3.14159D;
        double VOLUME = 0D;
        double R = 0;
        
        R = double.Parse(Console.ReadLine());
        
        VOLUME = (4.0D/3) * pi * (R*R*R);
        
        Console.WriteLine("VOLUME = " + String.Format("{0:0.000}", VOLUME));

    }

}
