using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Habitat
    {
        public Habitat(string locName)
        {
            this.locationName = locName;
        }
    public List<Animal> inhabitants = new List<Animal>();
    public string locationName { get; set;}
    }
}