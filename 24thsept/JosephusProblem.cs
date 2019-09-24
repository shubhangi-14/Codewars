// You are now to create a function that returns a Josephus permutation, taking as parameters the initial array/list of items to be permuted as if they were in a circle and counted out every k places until none remained.

// Tips and notes: it helps to start counting from 1 up to n, instead of the usual range 0..n-1; k will always be >=1.
using System;
using System.Collections.Generic;
public class Josephus
{
   public static List<object> JosephusPermutation(List<object> items, int k)
   {
       int n = items.Count;
       List<object> result = new List<object>();
       var i = 0;
       var j = 0;
       var m = 0;
       while (items.Count!=0)
       {
           j++;
                if (j == k)
                {
                    result.Add(items[i]);
                    items.RemoveAt(i);
                    m++;
                    i--;
                    j = 0;
                }
 
                if (m == n - 1)
                {
                    result.Add(items[0]);
                    items.RemoveAt(0);
                }
 
                if (i == items.Count - 1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
       }
       return result;
   }
}