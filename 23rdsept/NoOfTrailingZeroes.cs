// Write a program that will calculate the number of trailing zeros in a factorial of a given number.
using System;

public static class Kata 
{
  public static int TrailingZeros(int n)
  {
    int count = 0,i;
    for(i=5 ; n/i>=1 ; i = i*5)
    {
        count+= n/i;
    }
    return count;
  }
}