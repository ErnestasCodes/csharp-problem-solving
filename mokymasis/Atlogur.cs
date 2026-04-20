namespace mokymasis;

public class Atlogur
{
    public static void Run()
    {
        var n =int.Parse(Console.ReadLine());
        List<int> stiprumas = new List<int>();
        List<int> sveikata = new List<int>();
       
        
        for (int i = 0; i < n; i++)
        {
            var temp = Console.ReadLine().Split(' ');
            sveikata.Add(int.Parse(temp[0]));
            stiprumas.Add(int.Parse(temp[1]));
        }
        
        Console.WriteLine();
    
        int laimetojas_sveikata = sveikata[0];
        int laimetojas_indexas = 0;
        int laimetojas_stiprumas = stiprumas[0];
        for (int i = 1; i < n; i++)
        {
            int smugiai1 = (laimetojas_sveikata + stiprumas[i] - 1) / stiprumas[i];
            int smugiai2 = (sveikata[i] + laimetojas_stiprumas - 1) / laimetojas_stiprumas;
            
           
            if (smugiai1 >= smugiai2)
            {
              laimetojas_sveikata -= (smugiai2 - 1) * stiprumas[i];
            }
            else
            {
                laimetojas_sveikata =sveikata[i] - (smugiai1 ) * laimetojas_stiprumas;
                laimetojas_stiprumas = stiprumas[i];
                laimetojas_indexas = i;
            }
        }
       Console.WriteLine(laimetojas_indexas +1);
     
       

    }
}