using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class App
    {
        public List<Animal> animals = new List<Animal>();

        public void AddAnimals()
        {
            animals.Add(new Lynx("Bengt", "Male", 12, false));
            animals.Add(new Wolf("Wendy", "Female", 3, false));
            animals.Add(new Leopard("Berta", "Female", 4, true));
            animals.Add(new Lynx("Rolf", "Male", 5, true));
            animals.Add(new Crocodile("Croco", "Male", 10, true));
            animals.Add(new Wolf("Wolfy", "Male", 7, true));
            animals.Add(new Crocodile("Iza", "Female", 8, false));
        }
        
        public void PrintAnimalList()
        {
            //Formating for the list
            Console.WriteLine("ID\tAnimal\t\tFamily\t\tType\t\tName\t\tWild\t\tStatus");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            
            //Print each animal in the list, but check if they are mammals or reptiles.
            //Also seperate the animals to access their properties from the list.
            foreach (var item in animals)
            {
                if (item is Mammal mammal)
                {
                    if (mammal is Lynx lynx)
                    {
                        Console.WriteLine($"{lynx.AnimalId}\t{lynx.WhatAnimal}\t\t{lynx.AnimalFamily}\t\t{lynx.AnimalType}\t\t{lynx.Name}\t\t{lynx.IsWild}\t\t{lynx.MakeSound()}");
                    }
                    else if (mammal is Leopard leopard)
                    {
                        Console.WriteLine($"{leopard.AnimalId}\t{leopard.WhatAnimal}\t\t{leopard.AnimalFamily}\t\t{leopard.AnimalType}\t\t{leopard.Name}\t\t{leopard.IsWild}\t\t{leopard.MakeSound()}");
                    }
                    else if (mammal is Wolf wolf)
                    {
                        Console.WriteLine($"{wolf.AnimalId}\t{wolf.WhatAnimal}\t\t{wolf.AnimalFamily}\t\t{wolf.AnimalType}\t\t{wolf.Name}\t\t{wolf.IsWild}\t\t{wolf.MakeSound()}");
                    }
                }
                else if (item is Reptile reptile)
                {
                    if (reptile is Crocodile crocodile)
                    {
                        Console.WriteLine($"{crocodile.AnimalId}\t{crocodile.WhatAnimal}\t{crocodile.AnimalFamily}\t\t{crocodile.AnimalType}\t\t{crocodile.Name}\t\t{crocodile.IsWild}\t\t{crocodile.MakeSound()}");
                    }
                }
            }
        }

        public void Run()
        {
            //Add all new animals in a list
            AddAnimals();
            //Sort the animals if they are wild or not
            animals.Sort((x,y) => x.IsWild.CompareTo(y.IsWild));
            //Print the list of animals
            PrintAnimalList();
        }
    }
}
