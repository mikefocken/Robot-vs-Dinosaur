using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_Dinosaur_Project
{
    internal class Dinosaur
    {
        //Member variables (HAS A)
        public int health;
        public string name;
        public int attackPower;

        //Constructor
        public Dinosaur(string name)
        {
            this.health = 100;
            this.name=name;
            this.attackPower = 10;

        }
        //Member methods (CAN DOs)

        public void Attack(Robot robot)
        {
            robot.health = robot.health-attackPower;
            Console.WriteLine($"{name} attacks {robot.name} for {attackPower}\n{robot.name}'s health is now {robot.health}");
        }



    }
}
