﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, Point position) :
            base(name, position, 6)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if ((animal != null) && (animal.Size <= this.Size * 2))
            {
                this.Size++;
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }

        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining)
                {
                    this.Awake();
                }
                else
                {
                    this.sleepRemaining -= timeElapsed;
                }
            }
        }
    }
}
