using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Wizard
    {
        //fields
        private bool isGood;
        
        //Properties
        public bool IsGood
        {
            get { return this.isGood; }
            set { this.isGood = value; }
        }

        //Constructors
        public Wizard() { }

        public Wizard(bool isGood)
        {
            this.isGood = isGood;
        }
    }
}
