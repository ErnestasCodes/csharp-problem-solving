namespace mokymasis;
// Problem: Kattis - Attendance
// Ideja:
// 1. Nuskaitom visas eilutes po viena
// 2. Jei eilute yra vardas, isimename ji kaip paskutini pakviesta mokini
// 3. Jei po vardo eina "Present!", vadinasi tas mokinys dalyvauja
// 4. Jei po vardo ateina kitas vardas, vadinasi ankstesnis mokinys nedalyvavo
// 5. Gale, jei paskutinis vardas negavo "Present!", irgi pridedam ji prie nedalyvavusiu
// 6. Jei sarasas tuscias, isvedam "No Absences", kitaip isvedam visus vardus
public class Attendance
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        List<string> vardai = new List<string>();
        List<string> nera_isvedimas = new List<string>();
        List<string> nera = new List<string>();
        for (int i = 0; i < n; i++)
        {
            var vardas = Console.ReadLine();
            vardai.Add(vardas);
            nera.Add(vardas);
        }

        for (int i = 0; i < n; i++)
        {
            if (vardai[i] == "Present!")
            {
                nera[i] = "tuscia";
                nera[i - 1] = "tuscia";
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nera[i] != "tuscia")
            {
                nera_isvedimas.Add(nera[i]);
            }
        }
        if (nera_isvedimas.Count == 0)
        {
            Console.WriteLine("No Absences");
            return;
        }
        for (int i = 0; i < nera_isvedimas.Count; i++)
        {
            Console.WriteLine(nera_isvedimas[i]);
        }
    }
}