using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Ctor_MakesInstOf_Order()
    {
      Order o = new("Bulk order for BREADs", "Yum, yum!", 5000);
      Assert.AreEqual(typeof(Order), o.GetType());
    }

    [TestMethod]
    public void Ctor_SetsOrderDateTo_Now()
    {
      Order o = new("Bulk order for PASTRYs", "Yum, yum!", 4000);
      DateTime d = DateTime.Now;
      Assert.AreEqual(d.ToString(), o.Date.ToString());
    }

    [TestMethod]
    public void Ctor_GivesNewOrder_ValidGuid()
    {
      Order o = new("", "", 0);

      Assert.IsTrue(Guid.TryParse(o.Id.ToString(), out _));
    }
  }
}
