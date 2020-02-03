// CSharp
using System;

public class SplitString
{
  public static string[] Solution(string str)
  {
    string[] strArr = new string[str.Length / 2 + (str.Length % 2 == 0 ? 0 : 1)];
    int i;
    for (i = 0; i < str.Length;)
        strArr[i / 2] += str[i++] + (i == str.Length ? "_" : "");

    strArr[--i/2] = string.Concat(strArr[i/2][0], strArr[i/2][1]);
    return strArr;
  }
}
