using Microsoft.AspNetCore.Mvc;
using Brewery.Models;

namespace Brewery.Controllers
{

  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      return View ();
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

  }
}
