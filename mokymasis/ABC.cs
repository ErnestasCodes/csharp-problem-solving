using System.Windows.Markup;
using System;
// Problem: Kattis - ABC
// Idea:
// 1. Nuskaitom tris skaičius ir sudedam į listą
// 2. Surikiuojam skaičius didėjimo tvarka (Sort)
// 3. Nuskaitom raidžių seką (pvz. "ABC", "CBA" ir pan.)
// 4. Einam per kiekvieną raidę:
// 5. Sudedam į naują listą norima tvarka
// 6. Išvedam rezultatą su tarpais
namespace mokymasis;

public class ABC
{
    public static void Run()
    {
        var temp = Console.ReadLine().Split(' ');
        List<int> x = new List<int>();
        List<int> isvedimas = new List<int>();
        for (int i = 0; i < temp.Length; i++)
        {
            x.Add(int.Parse(temp[i]));
        }
        String raid = Console.ReadLine();
        x.Sort();
        for (int i = 0; i < raid.Length; i++)
        {
            if (raid[i] == 'A')
            {
                isvedimas.Add(x.Min());
            }
            else if (raid[i] == 'C')
            {
                isvedimas.Add(x.Max());
            }
            else
            {
                isvedimas.Add(x[1]);
            }
        }
        Console.Write(isvedimas[0]+ " " +  isvedimas[1] +  " " +  isvedimas[2]);
        
        
    }
}