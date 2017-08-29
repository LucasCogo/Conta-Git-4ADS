using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            for ( int i = 1; i <= 100; i++){
                
                if (i % 4 == 0 ){
                    Console.Write(i + ", ");
                }
            
            }
            
            Console.ReadKey();
        }
            
            
    }
}
