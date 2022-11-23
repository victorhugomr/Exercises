using System; 

class URI {

    static void Main(string[] args) { 
        
        int CODE = 0;
        int UNITS = 0;
        float PRICE = 0;
        float TOTAL = 0;
        string[] scanf = Console.ReadLine().Split();
        
        CODE = int.Parse(scanf[0]);
        UNITS = int.Parse(scanf[1]);
        PRICE = float.Parse(scanf[2]);
        TOTAL = TOTAL + (UNITS * PRICE);
        
        scanf = Console.ReadLine().Split();
        CODE = int.Parse(scanf[0]);
        UNITS = int.Parse(scanf[1]);
        PRICE = float.Parse(scanf[2]);
        TOTAL = TOTAL + (UNITS * PRICE);
        
        Console.WriteLine("VALOR A PAGAR: R$ " + String.Format("{0:0.00}", TOTAL));

    }

}
