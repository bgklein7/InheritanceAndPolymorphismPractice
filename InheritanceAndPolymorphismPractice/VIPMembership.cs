using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VIPMembership : Membership
    {
        //fields
        //invisible

        //Properties
        public bool IsSwanky { get; set; }

        //Constructors
        public VIPMembership()
        {
            //default construction
        }

        public VIPMembership(bool isSwanky)//the variable declared & assigned here is different than one that could have been created in fields
        {
            IsSwanky = isSwanky;// can use this. if want before property but not necessary
        }

        //Methods
        public override void Activate()
        {
            IsSwanky = true;

            if (IsActive == false)
            {
                IsActive = true; //this line changes it/re-assigns the value to true
                Console.WriteLine("You are now a big deal.");
            }
            else
            {
                Console.WriteLine("You're already a big deal.");
            }
        }

    }
}
