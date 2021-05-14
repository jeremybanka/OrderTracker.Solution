using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;

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
    public void NewOrder_Increments_OrderCount()
    {
      Vendor v = new("Suzy's Bakery", "Sells plenty of tasty BREADs.");
      int startingCount = v.Orders.Count;

      v.NewOrder("", "", 0);

      Assert.AreEqual(startingCount + 1, v.Orders.Count);
    }
  }
}
