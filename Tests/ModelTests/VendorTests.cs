using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorCtor_MakesInstOf_Vendor()
    {
      Vendor v = new("Suzy's Bakery", "Sells plenty of tasty BREADs.");
      Assert.AreEqual(typeof(Vendor), v.GetType());
    }
  }
}
