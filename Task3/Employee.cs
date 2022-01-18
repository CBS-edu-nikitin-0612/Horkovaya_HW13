using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public double Tax { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public Position Position { get; private set; }
        public Employee(string name, string surname, DateTime regDate, Position pos)
        {
            Name = name;
            Surname = surname;
            RegistrationDate = regDate;
            Position = pos;
            Tax = 0.05;
        }
    }
}