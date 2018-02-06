using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Membership
    {
        //fields
        private int memberID;
        private bool isActive;

        //Properties
        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        //Constructors

        public Membership()
        {
            //default constructor
        }

        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID; //first memberID refers to field; second memberID refers to parameter of constructor
            this.isActive = isActive;
        }

        //Method
        public virtual void Activate()
        {
            if(isActive == false)
            {
                isActive = true; //this line changes it/re-assigns the value to true
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }
        }
    }
}
