using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class Animal
    {
        string _sex;
        int _age;
        string _mood;
        bool _isWild;
        bool _isMamal;

        public List<Animal> animals = new List<Animal>();
        
        public string sex { get; set; }
        public int age { get; set; }
        public string mood { get; set; }
        public bool isWild { get; set; }
        public bool isMamal { get; set; }


        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}