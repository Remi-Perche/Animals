namespace Animals.Models.Animals
{
    public class Eagle : Animal, IFly
    {
        public Eagle() {
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
