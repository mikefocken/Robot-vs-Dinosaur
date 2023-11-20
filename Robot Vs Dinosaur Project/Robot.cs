using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_Dinosaur_Project
{
    internal class Robot
    {
        //Member variables (HAS A)
        public string name;
        public int health;
        public Weapon weapon;

        //Constructor
        public Robot(string name)
        {
            this.name = name;
            this.health= 100;
            weapon= new Weapon("Saber");
            


        }

        //Member methods (CAN DOs)
        public void Attack(Dinosaur dino)
        {
          dino.health = dino.health- weapon.attackPower;
           Console.WriteLine($"{name} attacks {dino.name} for {weapon.attackPower}\n{dino.name}'s health is now {dino.health}");

        }




    }
}
