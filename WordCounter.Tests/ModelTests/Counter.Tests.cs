using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void UserInputTest_IsThisAUsersInput_True()
    {
      string userInput = "*Ca$T!1?";
      bool result = userInput is string;
      Assert.AreEqual(true, result);
    }
  } // end of CounterTests

} // end of WordCounter.Tests
