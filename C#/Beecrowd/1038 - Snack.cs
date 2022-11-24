using System;

namespace Beecrowd{

	class URI {
		static void Main(string[] args){ 
			
			string[] scanf = Console.ReadLine().Split();
			int code = int.Parse(scanf[0]) - 1;
			double amount = double.Parse(scanf[1]);
			double[] prices = {4.00, 4.50, 5.00, 2.00, 1.50};
			double total = prices[code] * amount;

			Console.WriteLine($"Total: R$ {total:0.00}");

		}
	}
}
