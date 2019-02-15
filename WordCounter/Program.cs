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
      Console.WriteLine("Intro");
      Console.WriteLine("Instructions");
      Console.WriteLine("Enter word");
      string userWord = counter.Filter(Console.ReadLine().ToLower());
      Console.WriteLine("Enter sentence");
      string userSentence = counter.Filter(Console.ReadLine().ToLower());
      Console.WriteLine("Magic time!");
      int result = new Counter().Compare(userWord, userSentence);
      if (result == 0)
      {
        Console.WriteLine($"{char.ToUpper(userWord[0])}{userWord.Substring(1)} has NO matches found in '{userSentence}'...");
      }
      else if (result >= 0)
      {
        Console.WriteLine($"{char.ToUpper(userWord[0])}{userWord.Substring(1)} has {result} matches found in '{userSentence}'!");
      }
      else
      {
        Console.WriteLine("You broke it...Why!?");
      }
    }

  } // end of Program

} // end of WordCounter
