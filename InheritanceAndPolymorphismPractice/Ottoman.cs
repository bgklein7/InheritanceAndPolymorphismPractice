 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Ottoman : Furniture
    {
        private int volume;

        public int Volume
        {
            get { return this.volume; }
            set { this.volume = value; }
        }

        public Ottoman() { }

        public Ottoman(int volume, int Cost, bool Upholstered)
        {
            this.volume = volume;
            this.Cost = base.Cost;
            this.Upholstered = base.Upholstered;
        }

        public void UpholsteredCost()
        {
            if (Upholstered)
            {
                Console.WriteLine(Cost);
            }
            else
            {
                Console.WriteLine("No additional cost");
            }
        }

        public void VolumeCost()
        {
            if(volume >= 10)
            {
                Console.WriteLine(Cost);
            }
            else
            {
                Console.WriteLine("I don't know");
            }
        }
    }
    
}
