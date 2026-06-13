using System;

namespace mokymasis
{
    class Autori
    {
       public static void Run()
        {
            List<char> initials = new List<char>();
            string name = Console.ReadLine();
            foreach (var word in name.Split('-'))
            {
                initials.Add(word[0]);
            }
            Console.WriteLine(string.Join("", initials));
        }
    }
}
