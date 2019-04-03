using System.Collections.Generic;
using System;

namespace moonbook.Models
{
  class Planet
  {
    public string Name { get; private set; }
    string Description { get; set; }
    List<string> GuestBook { get; set; }

    Moon Moon { get; set; }

    Dictionary<Direction, Planet> NearbyPlanets { get; set; }

    public void AddNearbyPlanet(Direction direction, Planet planet)
    {
      NearbyPlanets.Add(direction, planet);
    }

    public Planet Travel(Direction dir)
    {
      if (NearbyPlanets.ContainsKey(dir))
      {
        return NearbyPlanets[dir];
      }
      Console.WriteLine("Your ship can't travel there. You suck.");
      return this;
    }

    public void SignBook(string name)
    {
      GuestBook.Add(name);
    }

    public void PrintGuestBook()
    {
      Console.WriteLine($"Visitors to planet {Name}: ");
      GuestBook.ForEach(name =>
      {
        Console.WriteLine(name);
      });
    }

    public Planet(string name, string desc, Moon moon = null)
    {
      GuestBook = new List<string>();
      Name = name;
      Description = desc;
      Moon = moon;
    }

  }
  public enum Direction
  {
    next,
    previous
  }

}