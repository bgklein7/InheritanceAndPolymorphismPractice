using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Couch : Furniture
    {
        private int seats;

        public int Seats
        {
            get { return this.seats; }
            set { this.seats = value; }
        }

        public Couch() { }

        public Couch(int seats, int Cost, string Color)
        {
            this.seats = seats;
            this.Cost = base.Cost;
            this.Color = Color;
        }

        public void CostSeat()
        {
            if (seats >= 3)
            {
                Console.WriteLine(Cost);
            }
            else
            {
                Console.WriteLine("Something something");
            }
        }

        public void ColorSeats()
        {
            if(Cost<= 1000)
            {
                Console.WriteLine("Couch is " + Color + " and has " + " seats.");
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
        }

        
    }
}
