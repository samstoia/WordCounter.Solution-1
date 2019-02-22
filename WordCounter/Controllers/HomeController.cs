using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.PlatformAbstractions;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  } // end of HomeController
} // end of WordCounter
