// What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

// 'abba' & 'baab' == true

// 'abba' & 'bbaa' == true

// 'abba' & 'abbba' == false

// 'abba' & 'abca' == false
// Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none.
using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    char[] wordArray = word.ToCharArray();
    Array.Sort(wordArray);
    string wordString = new string(wordArray);
    List<string> anagramList = new List<string>();
    foreach(string temp in words) {
        char[] wordsArray = temp.ToCharArray();
        Array.Sort(wordsArray);
        string wordsString = new string(wordsArray);
        if(wordString == wordsString)
        {
            anagramList.Add(temp);
        }
    }
    return anagramList;
  }
}