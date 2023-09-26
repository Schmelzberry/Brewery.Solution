using Microsoft.AspNetCore.Mvc;
using Brewery.Models;

namespace Brewery.AddControllers
{

  public class HomeController : controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View ();
    }
  }
}