// CSharp
using System;

public class Kata
{
  public static Int32 CalculateYears(Double Principal, Double Interest, Double Tax, Double DesiredPrincipal)
  {
    var years = 0;
    while (Principal < DesiredPrincipal){
      Principal += Principal * Interest * (1 - Tax);
      years++;
    }
    return years;
  }
}
