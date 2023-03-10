using CSharpAnimals.Models;
using CSharpAnimals.Services;

namespace CSharpAnimals.Models.Animals
{
    class Dragon : Animal ,ISteering, IFlying
    {   
        public override void Move()
        {
            Console.WriteLine("Le dragon se met en mouvement");
        }
        public new void Sleep() 
        {
            Console.WriteLine("Je suis un mechant Dragon qui s'est endormi");
        }

        public new void Moove() 
        {
            Console.WriteLine("Mooveeeeee");
        }

        public void Fly()
        {
            Console.WriteLine("Krokmouuuuuuuuuuuuuuuuu");
        }
    }
}
