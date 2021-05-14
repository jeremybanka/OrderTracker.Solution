using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Desc { get; }
    public List<Order> Orders { get; }
    public Vendor(string name, string desc)
    {
      Name = name;
      Desc = desc;
      Orders = new();
    }
    public void NewOrder(string name, string desc, int cost)
    {
      Orders.Add(new(name, desc, cost));
    }
  }
}