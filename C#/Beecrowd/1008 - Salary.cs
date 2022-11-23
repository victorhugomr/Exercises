using System; 

class URI {

    static void Main(string[] args) { 
        
        int NUNMBER = 0;
        int PERHOUR = 0;
        float HOURS = 0;
        float SALARY = 0;
        
        NUNMBER = int.Parse(Console.ReadLine());
        PERHOUR = int.Parse(Console.ReadLine());
        HOURS = float.Parse(Console.ReadLine());
        
        SALARY = PERHOUR * HOURS;
        
        Console.WriteLine($"NUMBER = {NUNMBER}");
        Console.WriteLine("SALARY = U$ " + String.Format("{0:0.00}", SALARY));

    }

}
