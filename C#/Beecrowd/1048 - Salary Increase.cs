using System;
using System.Linq;

namespace Beecrowd{

    public class Program{
        
    	public static void Main(){
    		
			double[] readjustmentRate = {15, 12, 10, 7, 4};
			double salary = double.Parse(Console.ReadLine());
			double newSalary = 0;
			double moneyEarned = 0;
			double percentage = 0;

    		if(salary <= 400){
    		    percentage = readjustmentRate[0];
    		    newSalary = salary * (1+percentage/100);
    		    moneyEarned = newSalary - salary;
    		}
    		else{
    		    if(salary > 400 && salary <= 800){
    		        percentage = readjustmentRate[1];
        		    newSalary = salary * (1+percentage/100);
        		    moneyEarned = newSalary - salary;
    		    }
    		    else{
    		        if(salary > 800 && salary <= 1200){
    		            percentage = readjustmentRate[2];
            		    newSalary = salary * (1+percentage/100);
            		    moneyEarned = newSalary - salary;
    		        }
    		        else{
    		            if(salary > 1200 && salary <= 2000){
    		                percentage = readjustmentRate[3];
                		    newSalary = salary * (1+percentage/100);
                		    moneyEarned = newSalary - salary;
    		            }
    		            else{
    		                percentage = readjustmentRate[4];
                		    newSalary = salary * (1+percentage/100);
                		    moneyEarned = newSalary - salary;
    		            }
    		        }
    		    }
    		}
			
			Console.WriteLine($"Novo salario: {newSalary:0.00}");
            Console.WriteLine($"Reajuste ganho: {moneyEarned:0.00}");
            Console.WriteLine($"Em percentual: {percentage} %");
    	}
    }
}
