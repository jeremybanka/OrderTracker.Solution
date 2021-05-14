using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Desc { get; }
    public List<Order> Orders { get; }
    private static List<Vendor> _instances = new();
    public Vendor(string name, string desc)
    {
      Name = name;
      Desc = desc;
      Orders = new();
      _instances.Add(this);
    }
    public void NewOrder(string name, string desc, int cost)
    {
      Orders.Add(new(name, desc, cost));
    }
    public static List<Vendor> All() => _instances;
    public static void Purge() { _instances.Clear(); }
  }
}