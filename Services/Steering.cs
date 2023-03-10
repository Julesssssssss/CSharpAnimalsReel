using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAnimals.Services;

namespace CSharpAnimals.Services
{
    class Steering : ISteering
    {
         void ISteering.Moove()
        {
            Console.WriteLine("Mooveeeeeeeee");
        }

    }
}
