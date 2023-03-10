using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAnimals.Services;
using CSharpAnimals.Models;
using System.Security.Cryptography.X509Certificates;

namespace CSharpAnimals.Models.Animals
{
    internal class Eagle : Animal  ,IFlying
    {
        string EagleName { get; set; }
        public Eagle(string EagleName) 
        {
            this.EagleName = EagleName;
        }
        public void Fly()
        {
            Console.WriteLine($" {EagleName} je vole");
        }
    }
}
