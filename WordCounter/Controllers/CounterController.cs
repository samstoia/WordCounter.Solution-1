using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.PlatformAbstractions;
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

    [HttpGet("/counter/match")]
    public ActionResult Compare(string userWord, string userSentence)
    {
      Counter counter = new Counter();
      string filterWord = counter.Filter(userWord);
      string filterSentence = counter.Filter(userSentence);
      int result = counter.Compare(filterWord, filterSentence);
      return View("Index", result);
    }
  } // end CounterController
} // end WordCounter
