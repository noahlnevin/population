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

    public void SpeciesYear() 
    {
      decimalNumber += rate;
      decimalNumber = Math.Round(decimalNumber,1);
      wholeNumber = Math.Floor(decimalNumber);
    }

  }
}