using System;

namespace population 
{
  class Species 
  {
    public string name;
    public double decimalNumber;
    public double wholeNumber;
    public int damage;
    public int health;
    public double rate;
    public double mortality;

    public void SpeciesYear() 
    {
      var death = YearlyMortality();
      //Console.WriteLine($"{death} {name}s died this year.");
      decimalNumber += rate - death;
      decimalNumber = Math.Round(decimalNumber,1);
      wholeNumber = Math.Floor(decimalNumber);
    }

    private double YearlyMortality() 
    {
      Random rnd = new Random();
      return Convert.ToDouble(rnd.Next(10)) * mortality;
    }

  }
}