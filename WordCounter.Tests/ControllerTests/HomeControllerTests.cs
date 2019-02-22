using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Index_ReturnCorrectViewOfIndex_True()
    {
      ActionResult indexView = new HomeController().Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

  } // end of HomeControllerTests
} // end of WordCounter
