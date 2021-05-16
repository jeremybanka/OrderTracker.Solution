using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Linq;

namespace OrderTracker
{
  public class OrdersController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(string vendorId) => View(Vendor.Find(vendorId));

    [HttpGet("vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(string vendorId, string orderId)
    {
      Vendor v = Vendor.Find(vendorId);
      Order o = v.FindOrder(orderId);
      return View((v, o));
    }

    [HttpPost("vendors/{vendorId}/orders")]
    public ActionResult Create(
      string vendorId,
      string name,
      string desc,
      int cost
    )
    {
      Vendor v = Vendor.Find(vendorId);
      v.NewOrder(name, desc, cost);
      Order o = v.Orders.Last();
      return Redirect($"vendors/{v.Id}/orders/{o.Id}");
    }
  }
}