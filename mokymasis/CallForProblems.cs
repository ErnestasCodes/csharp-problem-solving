namespace mokymasis;
using System;
using System.Collections.Generic;
// Problem: Kattis - Call for Problems
// Idea:
// 1. Nuskaitome, kiek yra uzduociu
// 2. Perskaitome kiekvienos uzduoties sudetingumo iverti
// 3. Patikriname, ar ivertis yra nelyginis
// 4. Jei skaicius nelyginis -> padidiname atmestu uzduociu skaiciu
// 5. Isvedame, kiek uzduociu buvo atmesta
public class CallForProblems
{
    public static void Run()
    {
       var n = int.Parse(Console.ReadLine());
       List<int> nelyginis = new List<int>();
       int kiekis = 0;
       for (int i = 0; i < n; i++)
       {
           var x =  int.Parse(Console.ReadLine());
           nelyginis.Add(x);
       }

       for (int i = 0; i < n; i++)
       {
           if (nelyginis[i] % 2 != 0)
           {
               kiekis++;
           }
       }
       Console.WriteLine(kiekis);
       
        
        
    }
    
}