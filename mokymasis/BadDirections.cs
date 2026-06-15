
using System;

namespace mokymasis
{
	
	public static class BadDirections
	{
		public static void Run()
		{
        List<int> key = new List<int>();
        List<string> pss = new List<string>();
          
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] dalys = Console.ReadLine().Split();

            int k = int.Parse(dalys[0]);
            string n = dalys[1];
            key.Add(k);
            pss.Add(n);
        }
    
          for (int i = 0; i < pss.Count; i++)
         {
                 string n = pss[i];

                 for (int j = 0; j < n.Length; j++)
                  {
                  int digit = n[j] - '0';

              //   Console.Write(digit + key[i]);
                 if(digit + key[i] > 9)
                    {
                        Console.Write((digit + key[i]) % 10);
                    }
                    else
                    {
                        Console.Write(digit + key[i]);
                    }
                 }
                 Console.WriteLine();
        }


			
		}

	
	}
}
