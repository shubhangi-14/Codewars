// In this simple Kata your task is to create a function that turns a string into a Mexican Wave. You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up.
using System;
using System.Collections.Generic;
namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> waveList = new List<string>();
            char[] temp = str.ToCharArray();
            int i;
            for(i=0;i<str.Length;i++)
            {
              if(!Char.IsWhiteSpace(temp[i]))
              {
                temp[i] = Char.ToUpper(temp[i]);
                waveList.Add(new String(temp));
                temp[i] = Char.ToLower(temp[i]);
              }
            }
            return waveList;
        }
    }
}