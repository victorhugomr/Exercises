using System; 

class URI {

    static void Main(string[] args) { 
        
        float MEDIA = 0;
        float A = 0;
        float B = 0;
        float C = 0;
        int weightA = 2;
        int weightB = 3;
        int weightC = 5;
        
        A = float.Parse(Console.ReadLine());
        B = float.Parse(Console.ReadLine());
        C = float.Parse(Console.ReadLine());
        
        MEDIA = ((A*weightA)+(B*weightB)+(C*weightC))/10;
        
        Console.WriteLine("MEDIA = " + String.Format("{0:0.0}", MEDIA));

    }

}
