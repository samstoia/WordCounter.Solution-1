using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Counter counter = new Counter();
      Console.WriteLine("\nWelcome to the word counter!\n-----\n\nThis simple program will ask you for a word and a sentence. It will then compare the two and return the number of occurences your word appears in your sentence.\n\n-----\n\nPlease enter a word:");
      string userWord = counter.Filter(Console.ReadLine().ToLower());
      Console.WriteLine("\nNow please write out a sentence to compare:");
      string userSentence = counter.Filter(Console.ReadLine().ToLower());
      if ((userWord == "") || (userSentence == ""))
        {
          Console.WriteLine("Whoops! Looks like you didn't enter anything, do it again!\n\n-----\n");
          Console.Read();
          Main();
        }
        else
        {
          Console.WriteLine("\n-----\n\nGreat! Time to do some counting! Press any key to continue.\n\n-----");
          Console.ReadKey();
          int result = new Counter().Compare(userWord, userSentence);
          if (result == 0)
          {
            Console.WriteLine($"{char.ToUpper(userWord[0])}{userWord.Substring(1)} has NO matches found in '{userSentence}'...\n");
          }
          else
          {
            Console.WriteLine($"{char.ToUpper(userWord[0])}{userWord.Substring(1)} has {result} matches found in '{userSentence}', congratulations!\n");
          }
          Console.ReadKey();
        }
    }

  } // end of Program

} // end of WordCounter
