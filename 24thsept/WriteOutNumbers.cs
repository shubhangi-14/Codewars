// Create a function that transforms any positive number to a string representing the number in words. The function should work for all numbers between 0 and 999999.
public class NumberTranslation
{
  public static string Number2Words(int n)
  {
    if(n == 0)
      return "zero";
    string word = "";
    if((n/1000)>0)
    {
        word += Number2Words(n/1000) + " thousand";
        n = n%1000;
        if(n>0)
          word += " ";
    }
    if((n/100)>0)
    {
        word += Number2Words(n/100) + " hundred";
        n = n%100;
        if(n>0)
          word += " ";
    }
    if (n>0)
    {
        var unitPlace = new[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
        var tenPlace = new[] {"zero","ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
        if(n<20)
          word += unitPlace[n];
        else
        {
          word += tenPlace[n/10];
          if((n%10)>0)
            word += "-" + unitPlace[n%10];
        }
    }
    return word;
  }
}