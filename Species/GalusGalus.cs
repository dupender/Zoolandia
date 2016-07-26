using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class GalusGalus : Galus
    {
        //constructor for RedPanda, string name is like joe, Steve, etc, base name is Animal
        public GalusGalus(string name) : base(name)
        {
            //dont need anything here because the base constructor takes care of it
        }
       public override string Eat(int numberOfFoodz)
       {    
           string animalEat = base.Eat(3); //base calls Animal, your parent class, returns "YUM"
           return animalEat + "Non nom nom";
       } 

       public string Eat(){
           return "I don't know what I just ate, but it was good";
       }


       public string Sleep(string name)
       {
           this.Name = name;
          // return this.Name;
          return Sleep();
       }

       public string Sleep()
       {
           return "Shhhhh " + this.Name + " is sleeping!";
       }
    }

}