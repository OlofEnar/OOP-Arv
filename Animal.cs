using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    //Base class
    internal class Animal
    {
        //Fields
        string _whatAnimal;
        string _animalType;
        string _animalFamily;
        string _name;
        string _sex;
        int _age;
        bool _isWild;
        string _animalId;
        string _status;

        //Properties
        public string WhatAnimal {  get; set; }
        public string AnimalType { get; set; }
        public string AnimalFamily { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public bool IsWild { get; set; }
        public string AnimalId { get; set; }
        public string Status { get; set; }

        public virtual string MakeSound()
        {
            Status = "The animal makes a sound";
            return Status;
        }
        
        //Method for getting the animal family class
        public string GetAnimalFamily()
        {
            string x = GetType().BaseType.Name;
            return x;
        }

        //Method for returning the animal type
        public string GetAnimalType()
        {
            string animalType = "";

            if (this is Mammal)
            {
                animalType = "Mammal";
            }
            else if (this is Reptile)
            {
                animalType = "Reptile";
            }
            else
            {
                animalType = "Unknown";
            }

            return animalType;
        }

        //Get the animal(class) name
        public string GetAnimal()
        {
            string x = GetType().Name;
            return x;
        }

    }
}