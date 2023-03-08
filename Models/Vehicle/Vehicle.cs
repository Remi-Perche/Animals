namespace Animals.Models.Vehicle
{
    public class Vehicle : IPilotage
    {
        public Vehicle() {
            this.name = "Vehicle";
        }
        public string name { get; set; }
        public void Moove()
        {
            Console.WriteLine($"{name} se déplace");
        }
    }
}
