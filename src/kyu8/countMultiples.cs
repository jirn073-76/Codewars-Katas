// Csharp
using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
    List<int> sol = new List<int>();
    for (int i = 1; i < xs.Count; i++){
      if((xs[i] % i) == 0){sol.Add(xs[i]);}
    }
    return sol;
  }
}
