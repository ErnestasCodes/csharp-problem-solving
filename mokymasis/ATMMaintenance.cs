namespace mokymasis;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;


// Problem: Kattis - ATM Maintenance
// Idea:
// 1. Einam per kiekvieną žmogų iš eilės
// 2. Tikrinam, ar bankomate dar yra pakankamai pinigų
// 3. Jei yra, išduodam pinigus ir sumažinam likutį
// 4. Jei nėra, pridedam 0, jei yra - pridedam 1
// 5. Gale išvedam visą atsakymą vienoje eilutėje
public class ATMMaintenance
{
    public static void Run()
    {
        List<int> money = new List<int>();
        var x = Console.ReadLine().Split(' ');
        var n = int.Parse(x[0]);
        var k = int.Parse(x[1]);
        List<int> isvedimas = new List<int>();
        
        var temp = Console.ReadLine().Split(' ');
        
        for (int i = 0; i < n; i++)
        {
            money.Add(int.Parse(temp[i]));
        }
        
            for (int i = 0; i < n; i++)
            {
                if (k - money[i] >= 0)
                {
                    k -= money[i];
                    isvedimas.Insert(i, 1);
                }
                else
                {
                    isvedimas.Insert(i, 0);
                }
            }
     

        for (int i = 0; i < n; i++)
        {
            Console.Write(isvedimas[i]);
        }
       



    }
    
}