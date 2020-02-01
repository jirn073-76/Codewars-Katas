// Csharp
using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
  int[] arr = new int[n];
  int posi = 0;
  for(int i = n; i > 0; i--){arr[posi] = i; posi++;}
  return arr;
  }
}
