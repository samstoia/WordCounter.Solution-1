using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class CounterController : Controller
  {
    [HttpGet("/counter")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/counter")]
    public ActionResult Count(string userWord, string userSentence)
    {
      // Counter counter = new Counter();
      // string filterWord = counter.Filter(userWord);
      // string filterSentence = counter.Filter(userSentence);
      // int result = counter.Compare(filterWord, filterSentence);
      Counter counter = new Counter(userWord, userSentence);
      return View("Index", counter);
    }
  } // end CounterController
} // end WordCounter
