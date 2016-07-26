namespace Zoolandia.Genus
{
    public class Galus : Animal
    {
        public Galus(string name) : base(name)
        {
            //dont need anything here because the base constructor takes care of it
        }

        public string color{get;set;}

        public override string laysEggs(int numOfEggs)
        {
            return base.laysEggs(5) + " eggs";
        }

    }





}
