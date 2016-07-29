using System;

namespace Zoolandia
{
    public class Surburbia : Habitat, IHabitat
    {
        public Surburbia(string locName) : base(locName)
        {

        }
        
        public float Climate()
        {
            return 78.8F;
        }

        public string ProximityToOthers()
        {
            return "close";
        }

    }


}