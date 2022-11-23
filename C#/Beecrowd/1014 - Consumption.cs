using System; 

class URI {

    static void Main(string[] args) { 
        
        int distance = int.Parse(Console.ReadLine());
        double spentFuel = double.Parse(Console.ReadLine());
        double averageConsumption = 0;
        
        averageConsumption = distance/spentFuel;
        
        Console.WriteLine($"{averageConsumption:0.000} km/l");

    }

}
