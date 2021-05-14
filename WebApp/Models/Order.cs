using System;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Name { get; }
    public string Desc { get; }
    public double Cost { get; }
    public DateTime Date { get; }
    public Guid Id { get; }
    public Order(string name, string desc, double cost)
    {
      Name = name;
      Desc = desc;
      Cost = cost;
      Date = DateTime.Now;
      Id = Guid.NewGuid();
    }
  }
}