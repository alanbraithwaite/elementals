using System;
using System.Collections.Generic;
using elementals.Models;

namespace elementals
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      //Pokemon pikachu = new Pokemon("Detective Pikachu");
      //pikachu.Speak();
      //pikachu.Name = "Pika";
      //pikachu.Speak();
      //pikachu.Speak("pikacuuuuuuuuu");

      //elements
      Element fire = new Element("fire");
      Element water = new Element("water");

      //pokemon
      Fire charmander = new Fire("Charmander", 175, "tail", fire);
      Water squirtle = new Water("squirtle", 30, "mouth", water);
      Water goldine = new Water("Goldine", 1, "Mouth", water);

      charmander.WonFight();
      charmander.Speak(3);
      System.Console.WriteLine(charmander.XP);


      // squirtle.Speak();
      //squirtle.Attack();
      //charmander.Attack();
      List<Pokemon> myPokemon = new List<Pokemon>();
      myPokemon.Add(charmander);
      myPokemon.Add(squirtle);
      myPokemon.ForEach(poke =>
      {
        poke.Attack();
      });

      System.Console.WriteLine(charmander.Element.Name);
    }
  }
}
