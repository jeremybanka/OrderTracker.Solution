using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() => View(Vendor.All());

    [HttpGet("/vendors/new")]
    public ActionResult New() => View();

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(string id) => View(Vendor.Find(id));

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string desc)
    {
      Vendor v = new(name, desc);
      return Redirect($"vendors/{v.Id}");
    }
  }
}