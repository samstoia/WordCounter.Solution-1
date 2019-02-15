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
    public void UserInputTest_IsThisAUsersInput_Bool_True()
    {
      string userInput = "*Ca$T!1?";
      bool result = userInput is string;
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Filter_FilterUserInputForWordCharactersWithRegex_String_True()
    {
      string userInput = ("*Ca$T!1?").ToLower();
      Regex Filter = new Regex(@"[^a-zA-Z]");
      string result = Filter.Replace(userInput, "");
      Assert.AreEqual("cat", result);
    }

    [TestMethod]
    public void Filter_FilterUserInputForWordCharactersWithArray_String_True()
    {
      string userInput = ("*Ca$T!1?").ToLower();
      string[] filter = {"0","1","2","3","4","5","6","7","8","9","0","!","@","#","$","%","^","&","*","(",")","?","<",">",".",","};
      foreach(string c in filter)
      {
        if (userInput.Contains(c))
        {
          userInput = userInput.Replace(c, "");
        }
      }
      Assert.AreEqual("cat", userInput);
    }
  } // end of CounterTests

} // end of WordCounter.Tests
