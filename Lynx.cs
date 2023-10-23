using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class Lynx : Cat
    {
        //Variable for holding lynx count
        static int _lynxCount = 0;

        //Constructor
        public Lynx(string name, string sex, int age, bool isWild)
        {
            AnimalType = GetAnimalType();
            AnimalFamily = GetAnimalFamily();
            WhatAnimal = GetAnimal();
            Name = name;
            Sex = sex;
            Age = age;
            IsWild = isWild;
            Status = MakeSound();

            //Add 1 for each lynx created
            _lynxCount++;
            //Shortname for the id
            AnimalId = "LYN" + _lynxCount;
        }

        public override string MakeSound()
        {
            Status = $"{Name} purrrrrsss";
            return Status;
        }
    }
}
