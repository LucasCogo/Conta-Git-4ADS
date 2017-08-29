using System;
					
public class Program
{
	public static void Main()
	{
        double[] salarios = new double [1000];
		double[] salariosAcrescimo = new double [1000];
		double acrescimo = 250 ;
		

		for (int i = 0 ; i <= 1000 ; i++){
            Console.WriteLine("Entre com o "+ (i+1) +"º salario");
            salarios[i] = Console.Read();
			salariosAcrescimo[i] = salarios[i] + acrescimo ;
            
        }
        
        Console.WriteLine("Lista dos Salarios com acrescimo");
        for(int i = 0; i <= salarios.Length; i++) {
                Console.WriteLine(salariosAcrescimo[i]);    
        }
    }
}