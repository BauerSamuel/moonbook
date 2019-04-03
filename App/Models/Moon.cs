using System.Collections.Generic;
using System;

namespace moonbook.Models
{
  class Moon : IDestination
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public Planet Planet { get; set; }

    public Planet GoBackToPlanet()
    {
      return Planet;
    }

    public Moon(string name, string desc, Planet planet)
    {
      Name = name;
      Description = desc;
      Planet = planet;
    }
  }
}