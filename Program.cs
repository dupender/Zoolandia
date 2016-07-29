using System;
using Zoolandia.Species;
using Zoolandia.Genus;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        //with abstract you cannot do this anymore        
           // Animal animal = new Animal();
           // animal.Name = "Steve";
           //string response =  animal.Eat(5);
           //Console.WriteLine(animal.Name + " says  " + response);
          // Console.ReadLine();

          //AilurusFulgens is a type below, it could be var redPanda
          AilurusFulgens redPanda = new AilurusFulgens("Steve");
          redPanda.Name = "Steve";
          string response = redPanda.Eat(5);

          Console.WriteLine(redPanda.Name + "says " + response);

          AilurusFulgens Joe = new AilurusFulgens("Joe");
          Console.WriteLine(Joe.Welcome("Joe"));
          Console.WriteLine(Joe.Name.ToLower());
         // Console.ReadLine();  

          GalusGalus chicken = new GalusGalus("Mack");
          Console.WriteLine(chicken.Sleep());
          chicken.numLegs = 2;
          chicken.color = "brown";
          chicken.Name = "Mack";
          Console.WriteLine("chicken has " + chicken.numLegs + " legs");
          Console.WriteLine("My chicken's name is " + chicken.Name);
          Console.WriteLine("This chicken is" + chicken.color);

          HomoSapien human = new HomoSapien("Dhru");
          human.Name = "Dhru";
          human.canRun = true;
          if(human.canRun){Console.WriteLine(human.Name + " can run ");};
          Console.WriteLine(human.Name + " is a human");
          Console.WriteLine(human.Hello());

          
        Surburbia longIsland = new Surburbia("Long Island");
        longIsland.inhabitants.Add(human);
        longIsland.inhabitants.Add(chicken);

         Farm magnolia = new Farm("Magnolia");
        magnolia.inhabitants.Add(human);
        magnolia.inhabitants.Add(chicken);  
        
      //  Console.WriteLine(Animal.name+ " has a husbandry level of "+ HomoSapien.husbandry);
        


        }
    }
}
