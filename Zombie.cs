using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        public Zombie(string name, Point position):
            base(name, position, 1)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            this.Size = 1;
            return 10;
        }
    }
}
