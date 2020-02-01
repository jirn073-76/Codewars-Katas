// Csharp
using System;

public static class Kata
{
  public static bool CheckTheBucket(string[] bucket)
  {
    int index = Array.IndexOf(bucket, "gold");
    if (index > -1){return true;}
    else{return false;}
  }
}
