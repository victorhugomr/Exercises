using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] scanf = Console.ReadLine().Split();
        string[] scanf2 = Console.ReadLine().Split();
        double x1 = double.Parse(scanf[0]);
        double y1 = double.Parse(scanf[1]);
        double x2 = double.Parse(scanf2[0]);
        double y2 = double.Parse(scanf2[1]);
        double distance = 0;
        
        distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
        
        Console.WriteLine($"{distance:0.0000}");

    }

}
