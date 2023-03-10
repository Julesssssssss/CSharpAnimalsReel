using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimals.Services
{
    internal class Flying : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("I belive i can fly");
        }
    }
}
