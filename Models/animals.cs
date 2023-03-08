namespace CSharpAnimals.Models
{
    abstract class Animal
    {
    public string Name { get; private set; }
    public Animal()
    {
        this.Name = "Bagherra";
    }
    public Animal(string name)
    {
        this.Name = name;
    }

    public virtual void Move()
    {
        Console.WriteLine("Move");
    }

    public void Sleep()
    {
        Console.WriteLine("zZZ");
    }

    }
}

