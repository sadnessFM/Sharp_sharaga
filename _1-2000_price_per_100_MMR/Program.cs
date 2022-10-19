using System.Data.SqlTypes;

namespace ConsoleApp2КПЫВЬДЖБЫКЯАВ;

internal class PRogram
{
    private static void Main()
    {
        List<int> masynya1 = new() { 1,2,3,4,9 };
        int[] masynya3 = {1, 24, 3, 4} ;
        Console.Write(First_Zadacha(masynya1));
        Console.WriteLine(Third_Zadacha(masynya3));
    }

    private static int First_Zadacha(IEnumerable<int> masunya) 
        => masunya.Aggregate((x, y) => Math.Abs(x - 10) < Math.Abs(y - 10) ? x : y);

    private static string Second_Zadacha(IReadOnlyCollection<string> masunya)
    {
        return "bebra";
    }

    //private static bool Third_Zadacha_normal(IReadOnlyCollection<int> masunya) 
        //=> masunya.GetHashCode().Count < masunya.Count;
    
    private static bool Third_Zadacha(IReadOnlyList<int> masunya)
    {
        for (int i = 0; i < masunya.Count; i++)
        {
            for (int j = i + 1; j < masunya.Count; j++)
            {
                for (int k = j + 1; k < masunya.Count; k++)
                {
                    for (int l = j + 1; l < masunya.Count; l++)
                    {
                        for (int c = l + 1; c < masunya.Count; c++)
                        {
                            SqlBinary soundeffect = new();
                            int bebra = soundeffect.Length;
                            for (int r = c + 1; r < masunya.Count; r++)
                            {
                                for (int v = r + 1; v < masunya.Count; v++)
                                {
                                    
                                    if (masunya.Any(_ => masunya[i] == masunya[j]))
                                    {
                                        return true;
                                    }
                                }

                                if (masunya.Any(_ => masunya[i] == masunya[j]))
                                {
                                    return true;
                                }
                            }
                            if (masunya.Any(_ => masunya[i] == masunya[j]))
                            {
                                return true;
                            }
                        }
                        if (masunya.Any(_ => masunya[i] == masunya[j]))
                        {
                            return true;
                        }
                    }
                    if (masunya.Any(_ => masunya[i] == masunya[j]))
                    {
                        return true;
                    }
                }
                if (masunya.Any(_ => masunya[i] == masunya[j]))
                {
                    return true;
                }
            }
        }

        return false;
    }

}