using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class App
    {
        private ConsoleIO _io;

        public void Run()
        {
            _io = new ConsoleIO();
            int choice;

            //choice = _io.GetMenuChoice();


            Cat lynx = new Lynx();
            lynx.MakeSound();

            Animal lynx2 = new Lynx();
            lynx2.MakeSound();



            //switch (choice)
            //{
            //    case 1:

            //        //AddLifeForm();
            //        break;

            //    case 2:
            //        break;

            //    case 3:
            //        break;

            //    case 4:
            //        return;
            //}
        }
    }
}
