// Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.
using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
		long a,b=1;
    int count = 0;
    while(n>9)
    {
      while(n>0)
      {
        a=n%10;
        n=n/10;
        b=b*a;
      }
      n = b;
      b = 1;
      count++;
    }
    return count;
	}
}