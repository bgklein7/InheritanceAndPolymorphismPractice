﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Couch couchOne = new Couch(2, 1500, "blue");
            //couchOne.CostSeat();


            //Ottoman ottomanOne = new Ottoman(250, 2500, true);
            //ottomanOne.UpholsteredCost();

            Wizard wizardOne = new Wizard(true);

            HogwartsStudent longbottom = new HogwartsStudent(7);

            DeathEater malfoy = new DeathEater();

            wizardOne.MakeMagic(); //don't need console.writeline
            longbottom.MakeMagic();
            malfoy.MakeMagic();
          
        }
    }
}
