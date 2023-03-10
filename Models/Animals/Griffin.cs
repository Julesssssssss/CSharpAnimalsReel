using CSharpAnimals.Models;
using CSharpAnimals.Services;

namespace CSharpAnimals.Models.Animals
{
    class Griffin : Animal, IFlying
    {
        public override void Move()
        {
            Console.WriteLine("Le griffin bouge");
        }
        public new void Sleep()
        {
            Console.WriteLine("Le griffin dort");
        }

        public void Fly() 
        {
            Console.WriteLine("Le GRIFFON IL VOLE ");
        }

    }
}
