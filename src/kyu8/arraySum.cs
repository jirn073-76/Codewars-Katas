// CSharp

public static class Kata
{
  public static int ArrayPlusArray(int[] arr1, int[] arr2)
  {
    int sol = 0;
    for(int i = 0; i < arr1.Length; i++){sol += arr1[i];}
    for(int i = 0; i < arr2.Length; i++){sol += arr2[i];}
    return sol;
  }
}
