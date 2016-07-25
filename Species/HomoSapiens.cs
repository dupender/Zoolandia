using System;

namespace Zoolandia.Species
{
    public class HomoSapien : Animal
    {
        //constructor for RedPanda, string name is like joe, Steve, etc, base name is Animal
        public HomoSapien(string name) : base(name)
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


       public string Hello(string name)
       {
           this.Name = name;
          // return this.Name;
          return Hello();
       }

       public string Hello()
       {
           return "Hello, " + this.Name;
       }
    }

}