namespace Animals.Models.Animals
{
    class Griffin : Animal, IFly
    {
        public Griffin() {
            this.name = "Griffin";
            this.Name = "Griffin";
        }
        public string Name { get; set; }
        public Griffin(string name, string rarity, int ID)
        {
            this.name = name;
            this.rarity = rarity;
            this.Id = ID;
            this.Name = name;
        }
        public void Fly()
        {
            Console.WriteLine($"{name} vole");
        }
        public override void Move()
        {
            Console.WriteLine($"Le {name} court");
        }

        public new void Sleep()
        {
            Console.WriteLine($"Le {name} dort profondement");
        }

        
    }
}
