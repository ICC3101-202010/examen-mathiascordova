using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Person
    {
        protected string name;
        protected int age;
        protected string nation;
        protected int salary;

        public void SetPerson(string name, int age, string nation, int salary)
        {
            this.name = name;
            this.age = age;
            this.nation = nation;
            this.salary = salary;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetNation()
        {
            return nation;
        }

        public int GetSalary()
        {
            return salary;
        }
    }
}
