namespace ConsoleApp2КПЫВЬДЖБЫКЯАВ;

internal class PRogram
{
    private static void Main()
    {
        List<int> masynya1 = new() { 1,2,3,4,9 }; //9
        string[] masunya2 = {"flower", "fl", "flask"}; //fl
        int[] masynya3 = {1, 24, 3, 4}; //false
        
        Console.WriteLine(First_Zadacha(masynya1));
        Console.WriteLine(Second_Zadacha(masunya2));
        Console.WriteLine(Third_Zadacha(masynya3));
    }

    
    private static int First_Zadacha(IEnumerable<int> masunya) 
        => masunya.Aggregate((x, y) => Math.Abs(x - 10) < Math.Abs(y - 10) ? x : y);


    private static string Second_Zadacha(IReadOnlyList<string> masunya)
    {
        if (masunya.Count == 0) return "";
        string minStr = masunya[0];

        for (int i = 1; i < masunya.Count; i++)
        {
            if (masunya[i].Length < minStr.Length)
                minStr = masunya[i];
        }

        int end = minStr.Length;

        foreach (string t in masunya)
        {
            int j;
            for (j = 0; j < end; j++)
            {
                if (minStr[j] != t[j])
                    break;
            }

            if (j >= end) continue;
            end = j;
        }

        return minStr[..end];
    }
     
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

   