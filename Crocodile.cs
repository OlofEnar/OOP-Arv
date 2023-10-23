using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class Crocodile : Reptile
    {
        //Variable for holding crocodile count
        static int _crocodileCount = 0;

        //Constructor
        public Crocodile(string name, string sex, int age, bool isWild)
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
            _crocodileCount++;
            //Shortname for the id
            AnimalId = "CRO" + _crocodileCount;
        }
        public override string MakeSound()
        {
            Status = $"{Name} is snooring";
            return Status;
        }
    }
}