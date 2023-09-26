using Microsoft.AspNetCore.Mvc;
using Brewery.Models;

namespace Brewery.Controllers
{

  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View ();
    }

  }
}