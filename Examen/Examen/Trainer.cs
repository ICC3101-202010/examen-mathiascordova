using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Trainer: Person
    {
        protected int tacticPoints;

        public void SetTrainer(int tp)
        {
            tacticPoints = tp;
        }

        public int GetTP()
        {
            return tacticPoints;
        }

        public bool ChangePlayer(Player player)
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
