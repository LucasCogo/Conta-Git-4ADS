using System;
					
public class Program
{

	
//6 - Imprimir a tabuada de qualquer número fornecido pelo usuário.
//Para finalizar utilize o número –1. (Utilize os 2 tipos de repetição: While
//- For) 
	
	public static void Main()
	{
		Console.WriteLine("Digite um numero");
		
		string valor = Console.ReadLine( );
		
		int x = Convert.ToInt32(valor);
		
//6		
		
		//for
		for(int i = 0; i <= 10 ; i++)
		{ 
			int y =  i * x ;
			Console.WriteLine(y);
		}
		
		
		//while 
		int z = 0;
		while(z <= 10)
		{
			int c = z * x; 
			z++;
			Console.WriteLine(c);
		}
		
		
		
		
	}
	
	
	
}
