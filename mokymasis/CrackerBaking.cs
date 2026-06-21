
using System;

public class CrackerBaking
{
	public static void Run()
	{
		var input = int.Parse(Console.ReadLine());
        var i = 1;
        while(i * i< input)
        {
            i++;
        }
        Console.WriteLine(i);
	}
}
