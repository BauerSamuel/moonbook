using System;
using moonbook.Models;

namespace moonbook
{
  class App
  {

    public IDestination CurrentLocation { get; set; }
    public bool Running { get; set; }

    private void Initialize()
    {
      //planets
      Planet mercury = new Planet("Mercury", "It's hot here.");
      Planet venus = new Planet("Venus", "Everything is melting.");
      Planet earth = new Planet("Earth", "Might as well call it dirt.");
      Planet mars = new Planet("Mars", "This planet is entirely inhabited by robots.");
      Planet jupiter = new Planet("Jupiter", "Gas giant");
      Planet saturn = new Planet("Saturn", "The Lord of the Rings");
      Planet uranus = new Planet("Uranus", "Nope.");
      Planet neptune = new Planet("Neptune", "Sponge-bob's overloard.");
      Planet pluto = new Planet("Pluto", "The smallest of all.");


      //create moons
      Moon luna = new Moon("Luna", "The good old moon.", earth);
      Moon phobos = new Moon("Phobos", "The better of the two", mars);
      Moon ganymede = new Moon("Ganymede", "UR OH PA", jupiter);
      Moon titan = new Moon("Titan", "AE", saturn);
      Moon triton = new Moon("Triton", "A fine weapon, cold world.", neptune);
      Moon charon = new Moon("Charon", "Husband is Randy", pluto);

      //relationships
      mercury.AddNearbyDest(Direction.next, venus);
      venus.AddNearbyDest(Direction.previous, mercury);
      venus.AddNearbyDest(Direction.next, earth);
      earth.AddNearbyDest(Direction.moon, luna);
      earth.AddNearbyDest(Direction.next, mars);
      earth.AddNearbyDest(Direction.previous, venus);
      //Many more relationships

      CurrentLocation = earth;
      Running = true;
    }
    public void Run()
    {
      Initialize();
      while (Running)
      {
        System.Console.WriteLine($"{CurrentLocation.Name}: {CurrentLocation.Description}");
        Console.ReadLine();
        Planet curPlanet = (Planet)CurrentLocation;
        CurrentLocation = curPlanet.TravelToDest(Direction.previous);

      }
    }


    public App()
    {

    }


  }
}