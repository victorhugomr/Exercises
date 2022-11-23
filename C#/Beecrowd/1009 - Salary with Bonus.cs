using System; 

class URI {

    static void Main(string[] args) { 
        
        string NAME;
        double SALARY = 0;
        double SALES = 0;
        double TOTAL = 0;
        
        NAME = Console.ReadLine();
        SALARY = double.Parse(Console.ReadLine());
        SALES = double.Parse(Console.ReadLine());
        
        TOTAL = SALARY + 0.15*SALES;
        
        Console.WriteLine("TOTAL = R$ " + String.Format("{0:0.00}", TOTAL));

    }

}
