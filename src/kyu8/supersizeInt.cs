//Csharp
using System;
using System.Linq;

public class Kata
{
    public static long SuperSize(long num)
        => num > long.MaxValue ? num : long.Parse(String.Concat(num.ToString().OrderByDescending(x => x)));
}
