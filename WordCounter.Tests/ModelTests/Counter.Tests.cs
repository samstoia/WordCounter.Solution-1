using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void UserWordTest_IsThisAUsersInput_Bool_True()
    {
      string userWord = "*Ca$T!1?";
      bool result = userWord is string;
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Filter_FilterUserWordForWordCharactersWithRegex_String_True()
    {
      string userWord = ("*Ca$T!1?").ToLower();
      Regex Filter = new Regex(@"[^a-zA-Z]");
      string result = Filter.Replace(userWord, "");
      Assert.AreEqual("cat", result);
    }

    [TestMethod]
    public void Filter_FilterUserWordForWordCharactersWithArray_String_True()
    {
      string userWord = ("*Ca$T!1?").ToLower();
      string result = new Counter().Filter(userWord);
      Assert.AreEqual("cat", result);
    }

    [TestMethod]
    public void Filter_FilterUserSentenceForWordCharactersWithArray_String_True()
    {
      string userSentence = ("Th3i#s$$ I,s A ca9T!!1").ToLower();
      string result = new Counter().Filter(userSentence);
      Assert.AreEqual("this is a cat", result);
    }

    [TestMethod]
    public void SplitSentence_SplitUserSentenceIntoWords_Bool_True()
    {
      string userSentence = "this is a cat";
      string[] sentenceArray = userSentence.Split(' ');
      bool result = sentenceArray is string[];
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Match_CompareUserWordToUserSentenceForMatch_Bool_True()
    {
      string userWord = "cat";
      string userSentence = "this is a cat";
      string[] sentenceArray = userSentence.Split(' ');
      bool result = false;
      foreach (string word in sentenceArray)
      {
        result = (word == userWord);
      }
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Match_CompareUserWordToUserSentenceForMatch_Int_2()
    {
      string userWord = "cat";
      string userSentence = "this cat is a cat";
      string[] sentenceArray = userSentence.Split(' ');
      int result = 0;
      foreach(string word in sentenceArray)
      {
        if (word == userWord)
        {
          result++;
        }
      }
      Assert.AreEqual(2, result);
    }

  } // end of CounterTests

} // end of WordCounter.Tests
