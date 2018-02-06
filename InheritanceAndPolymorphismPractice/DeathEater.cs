using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class DeathEater : Wizard
    {
        //fields
        private bool hasDarkMark;

        //Properties
        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructors
        public DeathEater() : base(false)
        {
            //Could also write: this.IsGood = false //would have to get rid of : base(false)
        }

        //Methods

        public override void MakeMagic()
        {
            //base.MakeMagic();//if include this then would do everything in the base class method plus whatever is below
            Console.WriteLine("Crucio!");
        }
    }
}
