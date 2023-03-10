using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAnimals.Services;
using CSharpAnimals.Models;

namespace CSharpAnimals.Models.Animals
{
    internal class Eagle : Animal  ,IFlying
    {
        public new void Flying()
        {
            Console.WriteLine("je vole");
        }
    }
}
