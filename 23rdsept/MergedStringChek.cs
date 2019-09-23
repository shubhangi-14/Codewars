// At a job interview, you are challenged to write an algorithm to check if a given string, s, can be formed from two other strings, part1 and part2.

// The restriction is that the characters in part1 and part2 should be in the same order as in s.
using System;

public class StringMerger
{
	public static bool isMerge(string s, string part1, string part2)
	{
    char[] part1Array = part1.ToCharArray();
    char[] part2Array = part2.ToCharArray();
    char[] sArray = s.ToCharArray();
    bool result1 = false , result2 = false ;
    if(s.Equals(""))
    {
      return part1.Equals("") && part2.Equals("");
    }
    else {
    if(part1.Length !=0 && sArray[0] == part1Array[0])
      result1 = isMerge(s.Substring(1) , part1.Substring(1) , part2);
    if(part2.Length !=0 && sArray[0] == part2Array[0])
      result2 = isMerge(s.Substring(1) , part1 , part2.Substring(1));
    return result1 || result2;
    }
	}
}
