using Animals.Models.Vehicle;

namespace Animals.Models.Animals
{
    class Dragon : Animal, IPilotage
    {
        public Dragon()
        {
            this.name = string.Empty;
            this.dragonName = "Dragon";
        }
        public string dragonName { get; set; }
        public new string name { get; set; }
        public void Moove()
        {
            Console.WriteLine($"Le {dragonName} se déplace");
        }
        public override void Move()
        {
            Console.WriteLine($"Le {dragonName} vole");
        }
        public new void Sleep()
        {
            Console.WriteLine($"Le {dragonName} dort biiiiiiiiiien");
        }
    }
}
