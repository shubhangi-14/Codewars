// The main idea is to count all the occuring characters(UTF-8) in string. If you have string like this aba then the result should be { 'a': 2, 'b': 1 }

// What if the string is empty ? Then the result should be empty object literal { }

// For C#: Use a Dictionary<char, int> for this kata!
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    return str.GroupBy(s=>s).ToDictionary(gr=>gr.Key, gr=>gr.Count());
  }
}