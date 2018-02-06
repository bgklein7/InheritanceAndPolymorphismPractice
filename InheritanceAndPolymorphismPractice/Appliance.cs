using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public abstract class Appliance //notice abstract keyword
    {
        //fields
        private bool isElectric;

        //Properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //Constructors
        //none

        //Methods
        public abstract void Work(); //note second use of abstract keyword and no body.
    }
}
