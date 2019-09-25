// Write a function that counts how many different ways you can make change for an amount of money, given an array of coin denominations.
using System;
public static class Kata
{
   public static int CountCombinations(int money, int[] coins)
   {
    return findCount(money,coins,0);
   }
   public static int findCount(int money, int[] coins, int checkFromIndex)
   {
     if(money == 0)
       return 1;
     else if(money<0 || coins.Length == checkFromIndex)
       return 0;
     else
     {
       int withFirst = findCount(money - coins[checkFromIndex], coins, checkFromIndex);
       int withoutFirst = findCount(money,coins,checkFromIndex+1);
       return withFirst + withoutFirst;
     }
   }
   
}