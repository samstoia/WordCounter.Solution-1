using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _userWord;
    private string _userSentence;
    public int result;

    public Counter(string userWord, string userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
    }

    public string GetUserWord()
    {
      return _userWord;
    }
    public string GetUserSentence()
    {
      return _userSentence;
    }
    public int GetResult()
    {
      string userWord = _userWord;
      string userSentence = _userSentence;
      string word = Filter(userWord);
      string sentence = Filter(userSentence);
      int result = Compare(word, sentence);
      return result;
    }

    public string Filter(string input)
    {
      string[] filter = {"0","1","2","3","4","5","6","7","8","9","0","!","@","#","$","%","^","&","*","(",")","?","<",">",".",",","=","+","-","_","[","]","{","}","|","`","~","/","\\"};
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
