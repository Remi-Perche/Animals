using System.Runtime.CompilerServices;

namespace Animals
{
    public abstract class Animal
    {
        public string name { get; set; }
        public string rarity { get; set; }
        public int Id { get; set; }
        public abstract void Move();

        public virtual void Sleep()
        {
            Console.WriteLine($"{name} dort");
        }
        public Animal()
        {
            this.name = "Undefined";
            this.rarity = "Undefined";
            this.Id = 0;
        }
        public Animal(string name)
        {
            this.name = name;
            this.rarity = "Undefined";
            this.Id = 0;
        }
        public Animal(string name, string rarity, int Id)
        {
            this.name = name;
            this.rarity = rarity;
            this.Id = Id;
        }
    }
}