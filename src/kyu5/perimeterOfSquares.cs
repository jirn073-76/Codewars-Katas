// CSharp
using System.Numerics;
using System.Collections.Generic;

public class SumFct
{
    private static List<BigInteger> GenFibonacci(BigInteger n)
    {
        List<BigInteger> fibNumbers = new List<BigInteger>()
        { 0, 1 };

        for (int i = 0; i < n; i++)
            fibNumbers.Add(fibNumbers[i] + fibNumbers[i + 1]);
        return fibNumbers;
    }

    public static BigInteger perimeter(BigInteger n)
    {
        BigInteger solution;
        foreach (BigInteger bigInt in GenFibonacci(n))
            solution += bigInt;

        return solution * 4;
    }
}
