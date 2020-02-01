using System;

public static class Kata
{
  public static double SakuraFall(double v)
  {
    if(v <= 0)
      return 0;
   
    else
      return 400 / v;     
  }
}
