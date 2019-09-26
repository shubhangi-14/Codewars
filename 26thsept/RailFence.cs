// Create two functions to encode and then decode a string using the Rail Fence Cipher. This cipher is used to encode a string by placing each character successively in a diagonal along a set of "rails". First start off moving diagonally and down. When you reach the bottom, reverse direction and move diagonally and up until you reach the top rail. Continue until you reach the end of the string. Each "rail" is then read left to right to derive the encoded string. You can optionally include or dis-include punctuation.
using System;
using System.Collections.Generic;
public class RailFenceCipher
{
   public static string Encode(string s, int n)
   {
       char[,] encode = new char[n, s.Length];
       int i,j;
       for(i=0;i<n;i++)
       {
         for(j=0;j<s.Length;j++)
           encode[i,j] = '*';
       }
       bool dir = false;
       int row = 0, col = 0;
       for(i=0;i<s.Length;i++)
       {
         if(row == 0 || row == n-1)
           dir = !dir;
         encode[row, col++] = s[i];
         if(dir)
           row++;
         else
           row--;
       }
       string result = string.Empty;
       for(i=0;i<n;i++)
       {
         for(j=0;j<s.Length;j++)
         {
           if(encode[i, j] != '*')
             result +=encode[i,j];
         }
       }
       return result;
   }

   public static string Decode(string s, int n)
   {
       char[,] decode = new char[n, s.Length];
       int i,j;
       for(i=0;i<n;i++)
       {
         for(j=0;j<s.Length;j++)
         {
           decode[i, j] = '\n';
         }
       }
       bool dir = true;
       int row = 0, col = 0;
       for(i=0 ; i<s.Length ; i++)
       {
         if(row == 0)
           dir = true;
         if(row == n-1)
           dir = false;
        decode[row, col++] = '*';
        if(dir)
           row++;
         else
           row--;
       }
       int index = 0;
       row = 0;
       col = 0;
       for(i=0 ; i<n ; i++)
       {
         for(j=0 ; j<s.Length ; j++)
         {
           if(decode[i, j] == '*' && index<s.Length)
             decode[i, j] = s[index++];
         }
       }
       string result = string.Empty;
       for(i=0 ; i<s.Length ; i++)
       {
         if(row == 0)
           dir = true;
         if(row == n-1)
           dir = false;
         if(decode[row, col] != '*')
           result += decode[row, col++];
         if(dir)
           row++;
         else
           row--;
        }
        return result;
   }
}
