namespace elementals.Models
{
  abstract class Pokemon
  {
    protected string CreatedName { get; set; }
    public string Name { get; set; }
    //Property
    public int XP { get; private set; }

    public Element Element { get; set; }

    public Pokemon(string name, Element elem)
    {
      Name = name;
      XP = 10;
      CreatedName = name;
      Element = elem;
    }

    protected Pokemon(string name)
    {
      Name = name;
    }

    public virtual void Attack()
    {
      System.Console.WriteLine($"{Name} generically attacks");
    }

    public void WonFight()
    {
      XP += 10;
    }

    public void Speak()
    {
      System.Console.WriteLine(Name);
    }

    public void Speak(int num)
    {
      for (int i = 0; i < num; i++)
      {
        System.Console.WriteLine(Name);
      }
    }

    public void Speak(string greeting)
    {
      System.Console.WriteLine(greeting);
    }


  }
}