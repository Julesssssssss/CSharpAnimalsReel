using CSharpAnimals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimals.Models.Animals
{
    internal class Bird : Animal , IFlying
    {
        public void Fly() 
        {
            Console.WriteLine("Je ne m'en vais pas je vole, comprenez bien je vole sans fumée sans alcool je vole");
        }
    }
}
