using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;

namespace WordCounter.Tests
{
    [TestClass]
    public class CounterControllerTests
    {
      [TestMethod]
      public void Index_ReturnCorrectViewOfIndex_True()
      {
        ActionResult indexView = new CounterController().Index();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Compare_CompareMatchOfWordAndSentence_True()
      {
        string testWord = "cat";
        string testSentence = "that cat is a cat";
        ActionResult compareView = new CounterController().Compare(testWord, testSentence);
        Assert.AreEqual("Index", compareView);
      }

    }
}