namespace elementals.Models
{
  class Water : Pokemon
  {
    public int Volume { get; set; }
    public string Source { get; set; }

    public void WaterAttack()
    {
      System.Console.WriteLine($"{Name} sprays water from {Source}");
    }
    public Water(string name, int volume, string source, Element elem) : base(name, elem)
    {
      Volume = volume;
      Source = source;
    }
  }
}