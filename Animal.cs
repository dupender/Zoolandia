using System;

namespace Zoolandia
{
    public class Animal
    {
        //constructor, used when instantiating classes
        public Animal (string name)
        {
            this.Name = name;
        }
        public string Name {get; set;}

        //access, return type, Method(parameter type, parameter name)
        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!";
        }
    }

}