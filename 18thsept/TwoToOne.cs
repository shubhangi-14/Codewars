// Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

// each taken only once - coming from s1 or s2.
using System;
public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) 
  {
        string longest= s1+s2;
        char[] longestArray=longest.ToCharArray();
        Array.Sort(longestArray);
        char[] distinctSortedArray = new char[longest.Length];
        int i,j,index=0;
        for(i=0;i<longest.Length;i++)
        {
          for(j=0;j<i;j++)
          {
            if(longestArray[i]==longestArray[j])
            {
              break;
            }
          }
          if(j==i)
          {
            distinctSortedArray[index++]=longestArray[i];
          }
        }
        char[] sortedArray = new char[index];
        Array.Copy(distinctSortedArray,sortedArray,index);
        string result = new string(sortedArray);
        return (result);
  }
}