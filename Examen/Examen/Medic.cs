using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Medic: Person
    {
        protected int experiencePoints;

        public void SetMedic(int exp)
        {
            experiencePoints = exp;
        }

        public bool EvAndCure(Player player)
        {
            Random random = new Random();
            int change = random.Next(0, 2);
            if (change == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    
}
