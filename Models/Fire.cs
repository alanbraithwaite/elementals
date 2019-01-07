namespace elementals.Models
{
  class Fire : Pokemon
  {
    public int MaxTemp { get; set; }
    public string FireSource { get; set; }

    public override void Attack()
    {
      System.Console.WriteLine($"{Name} produces fire from {FireSource}");
    }


    public Fire(string name, int maxTemp, string fireSource, Element elem) : base(name, elem)
    {
      MaxTemp = maxTemp;
      FireSource = fireSource;
    }
  }
}