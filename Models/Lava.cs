namespace elementals.Models
{
  class Lava : Fire
  {
    public Lava(string name, int maxTemp, string fireSource) : base(name, maxTemp, fireSource)
    {
      CreatedName = "BURNANATOR";
    }
  }
}