namespace Animals.Models.Animals
{
    class Griffin : Animal
    {
        public Griffin() {
            this.name = "Griffin";
        }
        public Griffin(string name, string rarity, int ID)
        {
            this.name = name;
            this.rarity = rarity;
            this.Id = ID;
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
