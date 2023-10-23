using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class Wolf : Mammal
    {
        //Variable for holding leopard count
        static int _wolfCount = 0;

        //Constructor
        public Wolf(string name, string sex, int age, bool isWild)
        {
            AnimalType = GetAnimalType();
            AnimalFamily = GetAnimalFamily();
            WhatAnimal = GetAnimal();
            Name = name;
            Sex = sex;
            Age = age;
            IsWild = isWild;
            Status = MakeSound();

            //Add 1 for each leopard created
            _wolfCount++;
            //Shortname for the id
            AnimalId = "WOL" + _wolfCount;
        }

        public override string MakeSound()
        {
            Status = $"{Name} howls at the moon";
            return Status;
        }

    }
}
