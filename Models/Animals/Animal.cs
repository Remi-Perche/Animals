using System.Runtime.CompilerServices;

namespace Animals.Models.Animals
{
    public abstract class Animal
    {
        public string name { get; private set; }

        public abstract void Move();

        public virtual void Sleep()
        {
            Console.WriteLine($"{name} dort");
        }
        public Animal()
        {
            this.name = "Undefined";
        }
        public Animal(string name)
        {
            this.name = name;
        }
    }
}