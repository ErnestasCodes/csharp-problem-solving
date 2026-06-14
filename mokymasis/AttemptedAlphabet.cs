using System;

namespace mokymasis
{
    public class AttemptedAlphabet
    {
        public static void Run()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<char> usedLetters = new List<char>();
            List<char> missingLetters = new List<char>();
            string input = Console.ReadLine();

            usedLetters.AddRange(input);
            usedLetters.Sort();
           
            foreach (char letter in alphabet)
            {
                if(usedLetters.Contains(letter))
                {
                    continue;
                }
                else
                {
                    missingLetters.Add(letter);
                }
            }
            if(missingLetters.Count > 0)
            {
                Console.WriteLine(string.Join("", missingLetters));
            }
            else
            {
                Console.WriteLine("Good job!");
            }

        }
    }
}
