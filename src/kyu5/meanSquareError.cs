// CSharp

public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
    double valueDiffSum = 0;
    for(int i = 0; i < firstArray.Length; i++) {
      int valueDiff = firstArray[i] - secondArray[i];
      valueDiffSum += valueDiff * valueDiff;
    }
    
    return valueDiffSum / firstArray.Length;
  }
}
