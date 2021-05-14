using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Ctor_MakesInstOf_Vendor()
    {
      Vendor v = new("Suzy's Bakery", "Sells plenty of tasty BREADs.");
      Assert.AreEqual(typeof(Vendor), v.GetType());
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
