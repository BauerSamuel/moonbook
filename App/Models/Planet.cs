using System.Collections.Generic;
using System;

namespace moonbook.Models
{
  class Planet : IDestination
  {
    public string Name { get; set; }

    public string Description { get; set; }
    List<string> GuestBook { get; set; }

    Moon Moon { get; set; }

    Dictionary<Direction, IDestination> NearbyDestinations { get; set; }



    public void AddNearbyDest(Direction dir, IDestination dest)
    {
      NearbyDestinations.Add(dir, dest);
    }

    public IDestination TravelToDest(Direction dir)
    {
      if (NearbyDestinations.ContainsKey(dir))
      {
        return NearbyDestinations[dir];
      }
      Console.WriteLine("Your ship can't travel there. You suck.");
      return (IDestination)this;
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

    public Planet(string name, string desc)
    {
      GuestBook = new List<string>();
      NearbyDestinations = new Dictionary<Direction, IDestination>();
      Name = name;
      Description = desc;

    }

  }
  public enum Direction
  {
    next,
    previous,
    moon
  }

}