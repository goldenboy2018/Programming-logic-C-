using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_lab
{
    class Elevator
    {
        double MaxWeight;
        Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double CurrentWeight = 0;
            foreach (Passenger passenger in Occupants)
            {
                CurrentWeight += passenger.GetWeight();
            }
            return CurrentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }

}
    
