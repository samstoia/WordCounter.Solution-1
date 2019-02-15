using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    public string Filter(string input)
    {
      string[] filter = {"0","1","2","3","4","5","6","7","8","9","0","!","@","#","$","%","^","&","*","(",")","?","<",">",".",","};
      foreach(string c in filter)
      {
        if (input.Contains(c))
        {
          input = input.Replace(c, "");
        }
      }
      return input;
    }

    public int Compare(string userWord, string userSentence)
    {
      string[] sentenceArray = userSentence.Split(' ');
      int result = 0;
      foreach(string word in sentenceArray)
      {
        if (word == userWord)
        {
          result++;
        }
      }
      return result;
    }
  } // end of Counter

} // end of WordCounter.Models
