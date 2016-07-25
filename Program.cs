using System;
using Zoolandia.Species;


namespace ConsoleApplication
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
          Console.WriteLine(Joe.Welcome());
          Console.WriteLine(Joe.Name.ToLower());
         // Console.ReadLine();  

          GalusGalus chicken = new GalusGalus("Mack");
          Console.WriteLine(chicken.Sleep());
          chicken.numLegs = 2;
          chicken.Name = "Mack";
          Console.WriteLine("chicken has " + chicken.numLegs + " legs");
          Console.WriteLine("My chicken's name is " + chicken.Name);

          HomoSapien human = new HomoSapien("Dhru");
          human.Name = "Dhru";
          Console.WriteLine(human.Name + " is a human");
          Console.WriteLine(human.Hello());


        }
    }
}
