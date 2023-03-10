using Animals.Models.Vehicle;

namespace Animals.Models.Animals
{
    class Dragon : Animal, IPilotage
    {
        public Dragon()
        {
            this.name = "Dragon";
        }
        public Dragon(string dragonName, string rarity, int ID)
        {
            this.name = dragonName;
            this.rarity = rarity;
            this.Id = ID;
        }

        public new string name { get; set; }
        public void Moove()
        {
            Console.WriteLine($"Le {name} se déplace");
        }
        public override void Move()
        {
            Console.WriteLine($"Le {name} vole");
        }
        public new void Sleep()
        {
            Console.WriteLine($"Le {name} dort biiiiiiiiiien");
        }
    }
}
