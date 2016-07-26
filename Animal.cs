using System;

namespace Zoolandia
{
    public abstract class Animal
    {
        //constructor, you have to have a name for an animal, used when instantiating classes
        public Animal (string name)
        {
            this.Name = name;
        }
        public string Name {get; set;}

        //access, virtual, return type, Method(parameter type, parameter name)
        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!";
        }


        public virtual string laysEggs(int numOfEggs)
        {
            return "I have" + numOfEggs;
        }

        public int numLegs {get;set;}
        
    }

}