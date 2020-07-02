using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Player: Person
    {
        protected int attackPoints;
        protected int defencePoints;
        protected int shirtNumber;
        protected bool isKeeper;

        public void SetPlayer(int att, int def, int number, bool keep)
        {
            attackPoints = att;
            defencePoints = def;
            shirtNumber = number;
            isKeeper = keep;
        }

        public int GetAttack()
        {
            return attackPoints;
        }

        public int GetDef()
        {
            return defencePoints;
        }

        public int GetNumber()
        {
            return shirtNumber;
        }

        public bool CheckIfKeeper()
        {
            return isKeeper;
        }
    }
}
