// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;





List<String> uzduotis = new List<string>();

Console.WriteLine(
    "Pasirinkite meniu" +
    "\n1. Įvesti užduotis" +
    "\n2. Parodyti visas užduotis" +
    "\n0. Baigti darbą" +
    "\n3. Istrinti uzduoti" +
    "\n4. redaguoti uzduoti");

while (true)
{


    
    var sk = int.Parse(Console.ReadLine());
    switch (sk)
    {
        case 1:
            ivedimas(uzduotis);
        Console.WriteLine("pasirinkite kita veiksma arba spauskite 0 norint baigti darba");
            break;
        case 2:
            ivesdimas(uzduotis);
            Console.WriteLine("pasirinkite kita veiksma arba spauskite 0 norint baigti darba");
            break;  
        case 0:
            return 0;
        case 3:
            istrinimas(uzduotis);
            Console.WriteLine("pasirinkite kita veiksma arba spauskite 0 norint baigti darba");
            break;
        case 4:
            uzdkeitimas(uzduotis);
            Console.WriteLine("pasirinkite kita veiksma arba spauskite 0 norint baigti darba");
            break;

    }
}




static List<String> ivedimas(List<String> uzduotis)
{
  
    string a;
    
    while (uzduotis.Count < 2)
    {
      a = Console.ReadLine();
      uzduotis.Add(a);
    }
    return uzduotis;
    
    
}

static void ivesdimas(List<String> uzduotis)
{
    Console.WriteLine("uzduotis kurias reikia padaryti:");
    for (int i = 0; i < uzduotis.Count; i++)
    {
        Console.WriteLine("Nr:" + i + " " + uzduotis[i]);
    }
}

static void istrinimas(List<String> uzduotis)
{
    Console.WriteLine("uzduotis kurias reikia istrinti pasirinkite numeri:");
    var nr = int.Parse(Console.ReadLine());
    for (int i = 0; i < uzduotis.Count; i++)
    {
        uzduotis.RemoveAt(nr);
        break;
    }
    Console.WriteLine("uzduotis sekmingai istrinta");
    
}

static void uzdkeitimas(List<String> uzduotis)
{
    Console.WriteLine("uzduotis kurias reikia pakeisti pasirinkite numeri:");
    var nr = int.Parse(Console.ReadLine());
    for (int i = 0; i < uzduotis.Count; i++)
    {
        uzduotis.RemoveAt(nr);
        break;
    }
    Console.WriteLine("iveskite nauja uzduoti");
    var naujauz = Console.ReadLine();
    uzduotis.Insert(nr, naujauz);
}



