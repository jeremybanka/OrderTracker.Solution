using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;
using System.Linq;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.Purge();
      GC.SuppressFinalize(this);
    }

    [TestMethod]
    public void Ctor_MakesInstOf_Vendor()
    {
      Vendor v = new("Suzy's Bakery", "Sells plenty of tasty BREADs.");
      Assert.AreEqual(typeof(Vendor), v.GetType());
    }

    [TestMethod]
    public void Ctor_GivesNewVendor_ValidGuid()
    {
      Vendor v = new("", "");

      Assert.IsTrue(Guid.TryParse(v.Id.ToString(), out _));
    }

    [TestMethod]
    public void Ctor_AddsConstructedVendor_ToInstances()
    {
      string TEST = "TEST";

      new Vendor("", "");
      new Vendor(TEST, "");
      new Vendor("", "");

      Assert.AreEqual(3, Vendor.All().Count);
      Assert.AreEqual(TEST, Vendor.All()[1].Name);
    }

    [TestMethod]
    public void StaticNewOrder_Increments_OrderCount()
    {
      Vendor v = new("Suzy's Bakery", "Sells plenty of tasty BREADs.");
      int startingCount = v.Orders.Count;

      v.NewOrder("", "", 0);

      Assert.AreEqual(startingCount + 1, v.Orders.Count);
    }

    [TestMethod]
    public void StaticFind_ReturnsVendor_WithSpecificGuid()
    {
      Vendor v = new("", "");
      Guid g = v.Id;

      Vendor found = Vendor.Find(g.ToString());

      Assert.AreEqual(v, found);
    }
    [TestMethod]
    public void FindOrder_ReturnsOrder_WithSpecificGuid()
    {
      Vendor v = new("", "");
      v.NewOrder("", "", 0);
      Order o = v.Orders.Last();
      Guid g = o.Id;

      Order found = v.FindOrder(g.ToString());

      Assert.AreEqual(o, found);
    }
  }
}
