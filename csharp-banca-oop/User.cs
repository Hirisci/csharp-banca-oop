using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_banca_oop
{
    internal class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FiscalCode { get; set; }
        public int Salary { get; set; }

        public User(string name, string lastName, string fiscalCode, int salary)
        {
            Name = name;
            LastName = lastName;
            FiscalCode = fiscalCode;
            Salary = salary;
        }

        public string fullName()
        {
            return $"{Name} {LastName}";
        }


        public override string ToString()
        {
            return $"Nome: {fullName().PadLeft(30)} | Codice Fiscale: {FiscalCode} | Salario: {Convert.ToString(Salary).PadLeft(6)}";
        }


        static public bool equalsUser(User obj, User obj1)
        {
            return obj.FiscalCode == obj1.FiscalCode ? true : false;
        }

      
    }

   
}
