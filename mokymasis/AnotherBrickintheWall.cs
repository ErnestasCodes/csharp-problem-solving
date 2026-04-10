namespace mokymasis;
using System;
using System.Collections.Generic;

// Problem: Kattis - Another Brick in the Wall
// Idea:
// 1. Einam per plytas tokia tvarka, kokia jos duotos
// 2. Kaupiam dabartinės eilės ilgį
// 3. Jei eilės ilgis tampa lygus sienos pločiui, užbaigiam eilę ir pradedam naują
// 4. Jei eilės ilgis viršija sienos plotį, sienos užbaigti nepavyks
// 5. Jei pavyksta tiksliai užpildyti h eilučių, atsakymas yra YES, kitaip NO

public class AnotherBrickintheWall
{
    public static void Run()
    {
        var x = Console.ReadLine().Split(' ');
        var h = int.Parse(x[0]);
        var w = int.Parse(x[1]);
        var n = int.Parse(x[2]);
        var dabartine_eile = 0;
        var galutinis_aukstis = 0;
        List<int> b = new List<int>();
        var temp = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            b.Add(int.Parse(temp[i]));
        }

        for (int i = 0; i < n; i++)
        {
            dabartine_eile += b[i];
            
            if (dabartine_eile == w)
            {
                dabartine_eile = 0;
                galutinis_aukstis++;
            }
            else if (dabartine_eile > w)
            {
                Console.WriteLine("NO");
                return;
            }
        }

        if (galutinis_aukstis >= h)
        {
            Console.WriteLine("YES");
        }

        
    }
    
}