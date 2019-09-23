// The function perimeter has for parameter n where n + 1 is the number of squares (they are numbered from 0 to n) and returns the total perimeter of all the squares.
using System;
using System.Numerics;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    BigInteger a = 1, b = 1, c=0, sum = 0;
    for(BigInteger i=2; i<=n; i++)
    {
      sum+= a+b;
      c = a+b;
      a = b;
      b = c;
    }
    return 4*sum+8;
  }
}