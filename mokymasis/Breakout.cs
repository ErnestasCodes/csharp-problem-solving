using System;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;
using System.Linq;

namespace mokymasis
{
    public class Breakout
    {
        public static void Run()
        {
            var temp = Console.ReadLine().Split(' ');
            List<int> boxes = new List<int>();
            var n = int.Parse(temp[0]);
            var x = int.Parse(temp[1]);
            var m = int.Parse(temp[2]);
            int kiekisPries = 0;
            int kiekisPalei = 0;
            for(int i = 0; i < m; i++)
            {
                var box = int.Parse(Console.ReadLine());
                boxes.Add(box);
            }
          //  Console.WriteLine();
            boxes.Sort();
            for(int i = 0; i < m; i++)
            {
                if(boxes[i] < x)
                {
                    kiekisPries++;
                }
                else
                {
                    kiekisPalei++;
                }
            }
            if(kiekisPries < kiekisPalei)
            {
                Console.WriteLine(kiekisPries);
            }
            else
            {
                Console.WriteLine(kiekisPalei);
            }
           


        }
    }
}
