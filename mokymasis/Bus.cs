namespace mokymasis;
using System;
using System.Collections.Generic;
// Problem: Kattis - Bus
// Idėja:
// 1. Pastebim seką: 1, 3, 7, 15...
// 2. Kiekvienas atsakymas yra 2^k - 1
// 3. Nuskaitom kiekvieną k reikšmę
// 4. Apskaičiuojam 2^k - 1
// 5. Išvedam atsakymą
public class Bus
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        List<int> s = new List<int>();
        for (int i = 0; i < n; i++)
        {
            var temp = Console.ReadLine();
            s.Add(int.Parse(temp));
        }
        for (int i = 0; i < n; i++)
        {
           Console.WriteLine(Math.Pow(2,s[i]) - 1);
        }
    }
}