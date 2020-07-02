using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Match
    {
        private Team firstTeam;
        private Team secondTeam;
        bool validMatch;
        string TypeMatch;

        public void SetMatch(Team t1, Team t2)
        {
            firstTeam = t1;
            secondTeam = t2;
        }

        public void ValidateMatch()
        {
            if (firstTeam.GetTypeTeam() == secondTeam.GetTypeTeam())
            {
                validMatch = true;
                TypeMatch = firstTeam.GetTypeTeam();
            }
            else
            {
                validMatch = false;
            }
        }

        public string PlayMatch()
        {
            if (validMatch)
            {
                Random random = new Random();
                string matchResult = "Partido " + TypeMatch + "\n"+"Duracion: "+ random.Next(90,96)+" minutos"+"\n";
                matchResult += "\n" + firstTeam.StartingLineUp() +"\n" + secondTeam.StartingLineUp() + "\n";
                matchResult += "\n" + "Resultado final:" + "\n" + random.Next(0, 6) + " - " + random.Next(0, 6);
                return matchResult;
            }
            else
            {
                return "El partido no pudo ser jugado porque los equipos son de tipos distintos";
            }
        }
    }
}
