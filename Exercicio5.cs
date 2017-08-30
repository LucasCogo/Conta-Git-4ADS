using System;
					
public class Program
{
	public static void Main()
	{	
		int a = 5;

		
//-5		
		for(int i = 0; i <= 10 ; i++)
		{ 
			int y =  i * a ;
			Console.WriteLine(y);
		}
		
		
		int b = 0;
		while(b <= 10)
		{
			int c = b * a; 
			b++;
			Console.WriteLine(c);
		}
		
		
		
		
	}
}