using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace mokymasis
{
    
    public class TakingInventory
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());
            List<string> itemNames = new List<string>();
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
            
                 string[] parts = Console.ReadLine()!.Split();

                    string pavadinimas = parts[0];
                   int kiekis = int.Parse(parts[1]);

                     if (!inventory.ContainsKey(pavadinimas))
                     {
                    inventory[pavadinimas] = 0;
                
                     }           

                     inventory[pavadinimas] += kiekis;
                            
            }
            foreach (var item in inventory.OrderBy(x => x.Key))
            {
                
                int kiekis;
                if (item.Value % 64 == 0)
                {
                     kiekis = item.Value / 64;
                }
                else
                {
                     kiekis = item.Value / 64 + 1;
                }
             
                Console.WriteLine($"{item.Key} {kiekis}");
            }
        }    
    }
}
