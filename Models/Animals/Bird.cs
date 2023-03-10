namespace Animals.Models.Animals
{
    public class Bird : Animal, IFly
    {
        public Bird() {
            this.Name = name;
        }
        public string Name { get; set; }
        public void Fly()
        {
            Console.WriteLine($"{Name} vole");
        }
        public override void Move()
        {
        }
    }
}
