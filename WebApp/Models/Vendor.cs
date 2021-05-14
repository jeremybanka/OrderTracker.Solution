namespace OrderTracker
{
  public class Vendor
  {
    public string Name { get; }
    public string Desc { get; }
    public Vendor(string name, string desc)
    {
      Name = name;
      Desc = desc;
    }
  }
}