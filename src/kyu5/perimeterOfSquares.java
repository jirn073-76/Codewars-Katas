// Java

import java.math.BigInteger;
import java.util.ArrayList;

public class perimeterOfSquares {

  private static ArrayList<BigInteger> genFibonacci(BigInteger n)
    {
        ArrayList<BigInteger> fibNumbers = new ArrayList<BigInteger>();
        fibNumbers.add(BigInteger.ZERO);
        fibNumbers.add(BigInteger.ONE);
        
        for (BigInteger i = BigInteger.ZERO; i.compareTo(n) == -1; i = i.add(BigInteger.ONE))
            fibNumbers.add(fibNumbers.get(i.intValue()).add(fibNumbers.get(i.intValue() + 1)));
        return fibNumbers;
    }

    public static BigInteger perimeter(BigInteger n)
    {
        BigInteger solution = BigInteger.ZERO;
        for (BigInteger bigInt : genFibonacci(n))
            solution = solution.add(bigInt);
        
        return solution.multiply(BigInteger.valueOf(4));
  }
}
