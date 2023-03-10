using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAnimals.Models
{
    class Dog : Animal
    {
        public string DogName;

        public Dog(string Name, string Rarity, int ID, int age)
        {
            this.DogName = Name;
            this.Rarity = Rarity;
            this.ID = ID;
            this.Age = age;
        }
    }
}
