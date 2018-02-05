using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Furniture
    {
        //Fields
        private int cost;
        private string color;
        private string use;
        private bool upholstered;

        //Properties
        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Use
        {
            get { return this.use; }
            set { this.use = value; }
        }

        public bool Upholstered
        {
            get { return this.upholstered; }
            set { this.upholstered = value; }
        }

        public Furniture() { }
        
        public Furniture(string use)
        {
            this.use = use;
        }

        public string FurnitureUse()
        {
            if(use == "seating")
            {
                return use;
            }
            else
            {
                return color;
            }
        }
        
    }
}
