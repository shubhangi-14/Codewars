// Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.
public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
    int[] count = new int[n];
    for(int i=0;i<n;i++)
      count[i] = i+1;
    return count;
  }
}