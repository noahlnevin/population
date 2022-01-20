using System;

namespace population 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      var numRounds = StartingText();

      Species Human = new Species();
      Species Elf = new Species();
      Species Dwarf = new Species();
      Species Orc = new Species();

      InitializePopulation(Human, "Human", 20, 10, 5, 1, .1);
      InitializePopulation(Elf, "Elf", 20, 8, 7, .9, .08);
      InitializePopulation(Dwarf, "Dwarf", 20, 12, 7, .8, .06);
      InitializePopulation(Orc, "Orc", 20, 12, 5, 1.1, .12);

      for (int i=0; i<numRounds; i++) 
      {
        Human.SpeciesYear();
        Elf.SpeciesYear();
        Dwarf.SpeciesYear();
        Orc.SpeciesYear();
      }

      System.Console.WriteLine($"Human population is now {Human.wholeNumber}.");
      System.Console.WriteLine($"Elf population is now {Elf.wholeNumber}.");
      System.Console.WriteLine($"Dwarf population is now {Dwarf.wholeNumber}.");
      System.Console.WriteLine($"Orc population is now {Orc.wholeNumber}.");

      /*while (playerOption) 
      {
        PopulationRound();
        askUser();
      }*/
    }

    private static void InitializePopulation(Species species, string name, double number, int health, int damage, double rate, double mortality)
    {
      species.name = name;
      species.decimalNumber = number;
      species.health = health;
      species.damage = damage;
      species.rate = rate;
      species.mortality = mortality;
    }

    private static int StartingText() 
    {
      Console.WriteLine("Welcome to population generator! Please enter how many years you'd like the populations to grow.");
      var numRounds = Console.ReadLine();
      return Convert.ToInt32(numRounds);
    }
  }
}

