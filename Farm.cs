using System;

namespace Zoolandia
{
    public class Farm : Habitat, IHabitat
    {
        public Farm(string locName) : base(locName)
        {

        }
        
        public float Climate()
        {
            return 50.0F;
        }

        public string ProximityToOthers()
        {
            return "far";
        }

    }


}