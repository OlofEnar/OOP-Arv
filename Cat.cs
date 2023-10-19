using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class Cat : Animal
    {


        public Cat(string sex, int age, string mood, bool isWild, bool isMamal)
        {
            _sex = sex;
            _age = age;
            _mood = mood;
            _isWild = isWild;
            _isMamal = isMamal;



        }

    }
}
