using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private int biteSize;

        public Boar(string name, Point position):
            base(name, position, 4)
        {
            this.biteSize = 2;
        }

        public int TryEatAnimal(Animal animal)
        {
            if ((animal != null) && (animal.Size <= this.Size))
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }

        public int EatPlant(Plant p)
        {
            if (p != null)
            {
                this.Size++;
                return p.GetEatenQuantity(this.biteSize);
            }

            return 0;
        }
    }
}
