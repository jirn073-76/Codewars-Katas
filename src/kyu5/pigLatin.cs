// CSharp

using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
    => String.Concat(str.Split(' ').Select(s => s.Substring(1, s.Length-1) + s[0] + "ay ")).Trim();
}
