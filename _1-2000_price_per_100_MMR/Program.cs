List<int> masynya = new() { 1,2,3,4,9 }; 
Console.Write(masynya.Aggregate((x,y) => Math.Abs(x-10) < Math.Abs(y-10) ? x : y));