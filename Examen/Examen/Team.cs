using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Team: ITeam
    {
        private List<Player> allPlayers;
        private Trainer trainer;
        private Medic medic;
        private string name;
        private string type;

        public void SetTeam(List<Player> players,Trainer tr, Medic m,string name,string type)
        {
            allPlayers = players;
            trainer = tr;
            medic = m;
            this.name = name;
            this.type = type;
        }

        public List<Player> GetPlayers()
        {
            return allPlayers;
        }

        public Trainer GetTrainer()
        {
            return trainer;
        }

        public Medic GetMedic()
        {
            return medic;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTypeTeam()
        {
            return type;
        }

        public string StartingLineUp()
        {
            Player keeper = new Player();
            int keeperPlace = 0;
            string start = "Equipo: " + name+ "\n" +"Trainer: "+trainer.GetName()+"\n";
            for (int i = 0; i < allPlayers.Count(); i++)
            {
                if (allPlayers[i].CheckIfKeeper() == true)
                {
                    keeper = allPlayers[i];
                    keeperPlace = i;
                    start += "\n" + keeper.GetName() + ", Numero: " + keeper.GetNumber()+ "\n";
                    break;
                }
            }
            for (int i = 0; i < allPlayers.Count(); i++)
            {
                if (i == keeperPlace)
                {
                    continue;
                }
                else
                {
                    start += "\n" + allPlayers[i].GetName() + ", Numero: " + allPlayers[i].GetNumber();
                }
            }
            return start;
        }

        public bool CheckNations()
        {
            if (type == "nacional" || type == "Nacional")
            {
                bool checkNat = true;
                string nation="";
                for (int i = 0; i < allPlayers.Count(); i++)
                {
                    if (i == 0)
                    {
                        nation = allPlayers[i].GetNation();
                    }
                    else
                    {
                        if (nation == allPlayers[i].GetNation())
                        {
                            continue;
                        }
                        else
                        {
                            checkNat = false;
                            break;
                        }
                    }
                }
                return checkNat;
            }
            else
            {
                return false;
            }
        }
    }
}
