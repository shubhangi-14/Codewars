// Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.

// #Example 1: a1 = ["arp", "live", "strong"]

// a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

// returns ["arp", "live", "strong"]
using System;
class WhichAreIn
        {
            public static string[] inArray(string[] array1, string[] array2)
            {
               int i,j,index=0;
               string[] r= new string[50];
               for(i=0;i<array1.Length;i++)
               {
                 for(j=0;j<array2.Length;j++)
                 {
                    if(array2[j].Contains(array1[i])==true)
                    {
                       r[index++]=array1[i];
                       break;
                    }
                 }
               }
               string[] result = new string[index];
               Array.Copy(r,result,index);
               Array.Sort(result, StringComparer.InvariantCulture);
               return result;
            }
        }