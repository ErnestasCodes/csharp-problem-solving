using System.Runtime.InteropServices.ComTypes;
using System;
namespace mokymasis;
using System.Collections.Generic;
using System.Linq;

// Problem: Kattis - Black Friday
// Idea:
// 1. Suskaičiuojam kiekvieno skaičiaus pasikartojimus (GroupBy)
// 2. Paimam tik tuos, kurie pasikartoja 1 kartą
// 3. Randam didžiausią
// 4. Išvedam jo indeksą

public class blackfriday
{

    public static void Run()
    {
        var x = int.Parse(Console.ReadLine());
        List<int> kaul = new List<int>();
        List<int> temp1 = new List<int>();
        int max;
        var temp = Console.ReadLine().Split(' ');
        for (int i = 0; i < x; i++)
        {
            kaul.Add(int.Parse(temp[i]));
       
        }
          var ats =   kaul.GroupBy(x => x).Where(grupe => grupe.Count() == 1).Select(grupe => grupe.Key).ToList();

          if (ats.Count == 0)
          {
              Console.Write("none");
              return;
          }
          
          for (int i = 0; i < ats.Count; i++)
          {
              temp1.Add(ats[i]);
          }
          max = temp1.Max();
          for (int i = 0; i < x; i++)
          {
              if (kaul[i] == max)
              {
                  Console.Write(i+1);
              }
              
          }
    }
}