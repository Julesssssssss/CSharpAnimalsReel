namespace CSharpAnimals.Models
{
    abstract class Animal
    {
    public string Name { get; protected set; }
    public string Rarity { get; protected set; }
    public int ID { get; protected set; }
    public int Age { get; protected set; }
    public Animal()
    {
        this.Name = "Bagherra";
        this.Rarity = "Common";
        this.ID = 0;
        this.Age = 0;
    }
    public Animal(string name, string rarity, int ID, int age)
    {
        this.Name = name;
        this.Rarity = rarity;
        this.ID = ID;
        this.Age = age;
    }

    public virtual void Move()
    {
        Console.WriteLine("Move");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("zZZ");
    }

    }
}

