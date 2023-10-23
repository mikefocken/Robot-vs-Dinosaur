using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_Dinosaur_Project
{
    internal class Weapon
    {
        //Member variables (HAS A)
        public string name;
        public int attackPower;

        //Constructor
        public Weapon(string name)
        {
            this.name = name;
            this.attackPower = 10;
           

        }

        //Member methods (CAN DOs)


    }
}
