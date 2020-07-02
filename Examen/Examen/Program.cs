using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> p1 = new List<Player>() { };
            List<Player> p2 = new List<Player>() { };
            Team team1 = new Team();
            Team team2 = new Team();
            Match match = new Match();
            Random random = new Random();
            Console.WriteLine("Equipo 1");
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    
                    Console.Write("Ingrese nombre del arquero: ");
                    string name1 = Console.ReadLine();
                    Console.Clear();
                    
                    int age1 = random.Next(20, 37);
                    Console.Clear();
                    Console.Write("Ingrese nacionalidad: ");
                    string nat1 = Console.ReadLine();
                    Player player = new Player();
                    player.SetPerson(name1, age1, nat1, 100);
                    player.SetPlayer(0, 100, 1, true);
                    p1.Add(player);
                }
                else
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre del jugador: ");
                    string name1 = Console.ReadLine();
                    Console.Clear();
                    
                    int age1 = random.Next(20, 37);
                    Console.Clear();
                    Console.Write("Ingrese nacionalidad: ");
                    string nat1 = Console.ReadLine();
                    Player player = new Player();
                    player.SetPerson(name1, age1, nat1, 100);
                    player.SetPlayer(random.Next(20,100), random.Next(20, 100), random.Next(2, 100), false);
                    p1.Add(player);
                }
            }
            Console.Clear();
            Console.Write("Ingrese nombre del entrenador: ");
            string name = Console.ReadLine();
            Console.Clear();

            int age = random.Next(20, 37);
            Console.Clear();
            Console.Write("Ingrese nacionalidad: ");
            string nat = Console.ReadLine();
            Trainer t1 = new Trainer();
            t1.SetPerson(name, age, nat, 100);
            t1.SetTrainer(random.Next(20, 100));
            Console.Clear();
            Console.Write("Ingrese nombre del medico: ");
            name = Console.ReadLine();
            Console.Clear();
            
            age = random.Next(20, 37);
            Console.Clear();
            Console.Write("Ingrese nacionalidad: ");
            nat = Console.ReadLine();
            Medic m1 = new Medic();
            m1.SetPerson(name, age, nat, 100);
            m1.SetMedic(random.Next(20, 100));
            Console.Clear();
            Console.Write("Nombre del equipo: ");
            team1.SetTeam(p1, t1, m1, Console.ReadLine(), "");
            team1.CheckNations();

            Console.Clear();
            Console.WriteLine("Equipo 2");
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    
                    Console.Write("Ingrese nombre del arquero: ");
                    string name1 = Console.ReadLine();
                    Console.Clear();
                    
                    int age1 = random.Next(20, 37);
                    Console.Clear();
                    Console.Write("Ingrese nacionalidad: ");
                    string nat1 = Console.ReadLine();
                    Player player = new Player();
                    player.SetPerson(name1, age1, nat1, 100);
                    player.SetPlayer(0, 100, 1, true);
                    p2.Add(player);
                }
                else
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre del jugador: ");
                    string name1 = Console.ReadLine();
                    Console.Clear();
                    
                    int age1 = random.Next(20, 37);
                    Console.Clear();
                    Console.Write("Ingrese nacionalidad: ");
                    string nat1 = Console.ReadLine();
                    Player player = new Player();
                    player.SetPerson(name1, age1, nat1, 100);
                    player.SetPlayer(random.Next(20, 100), random.Next(20, 100), random.Next(2, 100), false);
                    p2.Add(player);
                }
            }
            Console.Clear();
            Console.Write("Ingrese nombre del entrenador: ");
            string name2 = Console.ReadLine();
            Console.Clear();
            
            int age2 = random.Next(20, 37);
            Console.Clear();
            Console.Write("Ingrese nacionalidad: ");
            string nat2 = Console.ReadLine();
            Trainer t2 = new Trainer();
            t2.SetPerson(name2, age2, nat2, 100);
            t2.SetTrainer(random.Next(20, 100));
            Console.Clear();
            Console.Write("Ingrese nombre del medico: ");
            name = Console.ReadLine();
            Console.Clear();
            
            age = random.Next(20, 37);
            Console.Clear();
            Console.Write("Ingrese nacionalidad: ");
            nat = Console.ReadLine();
            Medic m2 = new Medic();
            m2.SetPerson(name, age, nat, 100);
            m2.SetMedic(random.Next(20, 100));
            Console.Clear();
            Console.Write("Nombre del equipo: ");
            team2.SetTeam(p2, t2, m2, Console.ReadLine(), "");
            team2.CheckNations();

            Console.Clear();
            match.SetMatch(team1, team2);
            match.ValidateMatch();
            Console.WriteLine(match.PlayMatch());
        }
    }
}
