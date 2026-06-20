using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;


namespace mokymasis
{
    public class BottleOpening
    {
        public static void Run()
        {
            
            var bottles = int.Parse(Console.ReadLine());
            var bottlesToOpen = int.Parse(Console.ReadLine());
            List<int> bottleList = new List<int>();
            List<int> BottlesToOpenList = new List<int>();

            for(int i = 1; i <= bottlesToOpen; i++)
            {
               
                     BottlesToOpenList.Add(i);
                
            }
         
            if(bottlesToOpen > bottles)
            {
                Console.WriteLine("impossible");
                return;
            }
            else if(bottlesToOpen == bottles)
            {
               Console.WriteLine("impossible");
                return;
            }
            else
            {
              for(int i = 0; i < BottlesToOpenList.Count; i++)
              {
              
                 Console.WriteLine("open " + BottlesToOpenList[i] + " using " + bottles);
                
              }

           
            }

        }
    }
}