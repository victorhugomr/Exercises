using System; 

class URI {

    static void Main(string[] args) { 
        
        float MEDIA = 0;
        float A = 0;
        float B = 0;
        float weightA = 3.5F;
        float weightB = 7.5F;
        
        A = float.Parse(Console.ReadLine());
        B = float.Parse(Console.ReadLine());
        
        MEDIA = ((A*weightA)+(B*weightB))/11;
        
        Console.WriteLine("MEDIA = " + String.Format("{0:0.00000}", MEDIA));

    }

}
