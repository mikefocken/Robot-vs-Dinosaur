using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_Dinosaur_Project
{
    internal class Battlefield
    {
        //Member variables (HAS A)
        Dinosaur dino;
        Robot robo;
        

        //Constructor
        public Battlefield()
        {
            dino = new Dinosaur("T-Rex");
            robo = new Robot("KillerBorg");

        }
        //Member methods (CAN DOs)

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs. The game will run until one of the the two gladiators health reaches zero. Good Luck and prepare for battle!");
        }

        public void Battle()
        {
            while (dino.health > 0 && robo.health >0)
            {

                dino.Attack(robo);
                if (robo.health > 0)
                {
                    robo.Attack(dino);
                }
            }

        }

        public void DisplayWinner()
        {
            if (dino.health <= 0) 
            {
                Console.WriteLine($"Congratulations!{robo.name} You're are a legend among Robots");
            }
            if (robo.health <= 0) 
            {
                Console.WriteLine($"Congratulations!{dino.name} is victorious!!");
            }


        }

        public void RunGame()
        {
            DisplayWelcome();
            Battle();
            DisplayWinner();

        }

       


    }

}
