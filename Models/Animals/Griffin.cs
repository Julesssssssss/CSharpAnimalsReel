using CSharpAnimals.Models;



namespace CSharpAnimals.Models.Animals
{
    class Griffin : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Le griffin bouge");
        }
        public new void Sleep()
        {
            Console.WriteLine("Le griffin dort");
        }

    }
}
