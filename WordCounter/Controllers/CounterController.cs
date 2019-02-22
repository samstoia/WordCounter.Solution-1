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

    [HttpGet("/counter/new")]
    public ActionResult New(string userWord, string userSentence)
    {
      Counter counter = new Counter(userWord, userSentence);
      return View("New", counter);
    }
  } // end CounterController
} // end WordCounter
