
using System;

namespace mokymasis;

public class ThreeDPrintedStatues
{
    public static void Run()
    {
        var dalys = int.Parse(Console.ReadLine());
		int k = 0;
		int dienos = 0;
		
		while((int)Math.Pow(2, k) < dalys)
		{
       
		 k++;
		 dienos++;
			
			
		}
		Console.WriteLine(dienos+1);
    }
}