// In this example you have to validate if a user input string is alphanumeric. The given string is not nil, so you don't have to check that.

// The string has the following conditions to be alphanumeric:

// At least one character ("" is not valid)
// Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
// No whitespaces/underscore
using System.Text.RegularExpressions;

public class Kata
{
  public static bool Alphanumeric(string str)
  {
    Regex pattern = new Regex("^[a-zA-Z0-9]*$");
    if(str.Length !=0)
    {
      if(pattern.IsMatch(str))
          return true;
      else 
          return false;
    }
    return false;
  }
}