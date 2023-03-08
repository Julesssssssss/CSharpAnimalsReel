using CSharpAnimals.Models;


namespace CSharpAnimals.Models.Animals
{
    class Dragon : Animal
    {   
        public override void Move()
        {
            Console.WriteLine("Le dragon se met en mouvement");
        }
        public new void Sleep() 
        {
            Console.WriteLine("Je suis un mechant Dragon qui s'est endormi");
        }

        
    }
}
