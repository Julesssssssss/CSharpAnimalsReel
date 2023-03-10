using CSharpAnimals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimals.Models
{
    internal class Vehicle : ISteering
    {
        public void vehicle()
        {
            Console.WriteLine("Vroummmmmmmmmmm");
        }

        public void Moove()
        {
            Console.WriteLine("Moooveeeee");
        }
    }
}
