using System.Runtime.CompilerServices;

class Animal
{
    public string name;

    static void Main(string[] args)
    {
        Sleep();
        Move();
    }

    static void Move()
    {
        Console.WriteLine("Move");
    }

    static void Sleep()
    {
        Console.WriteLine("Sleep");
    }
    static Animal()
    {
        
    }
    public Animal(string name)
    {
        this.name = "Baguera";
    }
}