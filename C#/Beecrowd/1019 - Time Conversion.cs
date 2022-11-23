using System; 

class URI {

    static void Main(string[] args) { 
        
        int time = int.Parse(Console.ReadLine());
        int hours = time/3600;
        time = time%3600;
        int minutes = time/60;
        int seconds = time%60;
        
        Console.WriteLine($"{hours}:{minutes}:{seconds}");

    }

}
