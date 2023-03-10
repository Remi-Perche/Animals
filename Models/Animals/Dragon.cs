using Animals.Models.Vehicle;

namespace Animals.Models.Animals
{
    class Dragon : Animal, IPilotage, IFly
    {
        public Dragon()
        {
            this.name = "Dragon";
            this.Name = name;
        }
        public Dragon(string dragonName, string rarity, int ID)
        {
            this.name = dragonName;
            this.rarity = rarity;
            this.Id = ID;
            this.Name = name;
        }

        public new string name { get; set; }
        public string Name { get; set; }
        public void Fly()
        {
            Console.WriteLine($"{name} vole");
        }
        public void Moove()
        {
            Console.WriteLine($"Le {name} se déplace");
        }
        public override void Move()
        {
            Console.WriteLine($"Le {name} court");
        }
        public new void Sleep()
        {
            Console.WriteLine($"Le {name} dort biiiiiiiiiien");
        }
    }
}
