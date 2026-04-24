namespace mokymasis;
using System;
using System.Collections.Generic;
public class CinemaCrowds
// Problem: Kattis - Cinema Crowds
// Idea:
// 1. Einame per visas grupes is eiles
// 2. Jei grupe telpa i likusias vietas -> atimame jos dydi is N
// 3. Jei netelpa -> padidiname nepriimtu grupiu skaiciu
// 4. Ciklo nenutraukiame, nes velesnes grupes gali buti mazesnes
// 5. Isvedame nepriimtu grupiu skaiciu

{
    public static void Run()
    {
        var nm = Console.ReadLine().Split(' ');
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        var x = Console.ReadLine().Split(' ');
        int rejected = 0;

        for (int i = 0; i < m; i++)
        {
            int group = int.Parse(x[i]);

            if (group <= n)
            {
                n -= group;
            }
            else
            {
                rejected++;
            }
        }
        Console.WriteLine(rejected);
    }

}