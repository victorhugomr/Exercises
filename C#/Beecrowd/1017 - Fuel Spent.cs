using System; 

class URI {

    static void Main(string[] args) { 
        
        double spentTime = double.Parse(Console.ReadLine());
        double averageSpeed = double.Parse(Console.ReadLine());
        double SPENTFUEL = 12;
        double necessaryLiters = 0;
        
        necessaryLiters = (spentTime * averageSpeed)/SPENTFUEL;

        Console.WriteLine($"{necessaryLiters:0.000}");

    }

}
