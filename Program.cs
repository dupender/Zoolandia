using System;
using Zoolandia.Species;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           // Animal animal = new Animal();
           // animal.Name = "Steve";
           //string response =  animal.Eat(5);
           //Console.WriteLine(animal.Name + " says  " + response);
          // Console.ReadLine();

          AilurusFulgens redPanda = new AilurusFulgens("Steve");
          redPanda.Name = "Steve";
          string response = redPanda.Eat(5);

          Console.WriteLine(redPanda.Name + "says " + response);

          AilurusFulgens Joe = new AilurusFulgens("Joe");
          Console.WriteLine(Joe.Welcome("Joe"));
          Console.WriteLine(Joe.Name.ToLower());
          Console.ReadLine();        
        }
    }
}
