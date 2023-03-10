using Animals.Models.Animals;

namespace Animals.Models;
class Program
{
    static void Main(string[] args)
    {
        /*string[] dogs = { "Jack", "Medor", "Toby", "Snow", "Milou" };
        IEnumerable<string> notSnow =
            from dog in dogs
            where dog != "Snow"
            select dog;
        
        foreach (string dog in notSnow)
        {
            Console.WriteLine(dog);
        }*/
        Dragon smaug = new Dragon("Smaug", "Legendary", 1);
        Griffin Morpheus = new Griffin("Morpheus", "Rare", 2);
    }
}
