// See https://aka.ms/new-console-template for more information

using CSharpAnimals.Models;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Text;
using CSharpAnimals.Models.Animals;
using CSharpAnimals.Services;

class Program
{
    static void Main(string[] args)
    {
        Dragon Krokmou = new();
        Krokmou.Sleep();
        Krokmou.Move();
        Krokmou.Moove();
        Krokmou.Flying();

        Griffin Manu = new();
        Manu.Sleep();
        Manu.Move();
        Manu.Flying();

        Eagle Lionel = new();
        Lionel.Flying();

        Bird Emericus = new();
        Emericus.Flying();

        Dog chien = new("Snow","Commun",1,14);
        Dog chien1 = new("Armand","Rare",2, 15);
        Dog chien2 = new("Michelle","Commun",3, 5);
        Dog chien3 = new("Laurine", "Rare", 4, 8);
        Dog chien4 = new("Noemie", "Legendary", 5, 2);

        Dog[] dogs = { chien, chien1, chien2, chien3, chien4 };

        foreach (Dog dog in dogs)
        {
        if (dog.Age == 8 || dog.Rarity == "Rare")
            {
                Console.WriteLine(dog.DogName);
            }
        }

        
       








}
}




