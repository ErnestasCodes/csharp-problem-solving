namespace mokymasis;
// Problem: Kattis - Abby's Absolutes
// Idea:
// 1. Nuskaitome maksimalų obuolių kiekį N ir kelionių skaičių K
// 2. Nuskaitome K norimų obuolių kiekių
// 3. Kiekvienam kiekiui palyginame atstumą iki 1 ir iki N
// 4. Jei kiekis arčiau N, išvedame N
// 5. Jei kiekis arčiau 1 arba atstumas vienodas, išvedame 1
public class Abby_sAbsolutes
{
    public static void Run()
    {
        
        var x = Console.ReadLine().Split(' ');
        var MaxNupirks = int.Parse(x[0]);
        var Keliones = int.Parse(x[1]);
        List<int> NorimasKiekis = new List<int>();
        List<int> isvedimas = new List<int>();
        
        var temp = Console.ReadLine().Split(' ');
        for (int i = 0; i < Keliones; i++)
        {
            NorimasKiekis.Add(int.Parse(temp[i]));
        }

        for (int i = 0; i < Keliones; i++)
        {
            if (MaxNupirks - NorimasKiekis[i] < NorimasKiekis[i] - 1)
            {
                isvedimas.Add(MaxNupirks);
            }
            else if (MaxNupirks - NorimasKiekis[i] > NorimasKiekis[i] - 1)
            {
                isvedimas.Add(1);
            }
            else
            {
                isvedimas.Add(1);
            }
        }

        for (int i = 0; i < Keliones; i++)
        {
            Console.Write(isvedimas[i] + " ");
        }
        
    }
}