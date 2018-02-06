using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class StandardMembership : Membership
    {
        //fields
        //invisible
        
        //Properties
        public int Cost { get; set; } //Short hand for field creation and get & set lines. More likely to see it this way.//if don't use fields then refer to property in constructors

        //Constructors
        public StandardMembership()
        {
            //default constructor
        }

        public StandardMembership(int cost)
        {
            Cost = cost; //because did not use fields must refer to Property.  Lower case cost still refers to parameter. Don't need to use this.
        }

        //Methods
        public override void Activate()
        {
            if (IsActive == false)
            {
                IsActive = true; //this line changes it/re-assigns the value to true
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }
            //base.Activate();
        }
    }
}
