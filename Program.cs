using Animals.Models.Animals;

namespace Animals.Models;
class Program
{
    static void Main(string[] args)
    {
        Griffin griffin = new Griffin();
        griffin.Sleep();
        griffin.Move();
        Console.WriteLine(griffin.name);

        Dragon dragon = new Dragon();
        dragon.Sleep();
        dragon.Move();
    }
}
