namespace mokymasis;
// Problem: Kattis - Thirsty Cow
// Idėja:
// 1. Perskaitom visus vandens kiekius
// 2. Pastebim, kad bendras išgeriamas kiekis negali viršyti didžiausio a[i]
// 3. Todėl atsakymas yra tiesiog didžiausias masyvo elementas
// 4. Randam max reikšmę
// 5. Išvedam atsakymą
public class ThirstyCow
{
    public static void Run()
    {
        var x = Console.ReadLine().Split(' ');
        var n = int.Parse(x[0]);
       
        
        List<int> b = new List<int>();
        var temp = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            b.Add(int.Parse(temp[i]));
        }
        Console.WriteLine(b.Max());
        
        

    }
}