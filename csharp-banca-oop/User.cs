using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    //visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.
    }

   
}
