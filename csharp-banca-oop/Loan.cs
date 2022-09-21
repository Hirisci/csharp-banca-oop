using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Loan
    {
        public int Id { get; protected set; }
        public User Contractor { get; protected set; }
        public float Ammount { get; protected set; }
        public float Installment { get; protected set; }
        public DateTime start { get; protected set; }
        public DateTime end { get; protected set; }


        public override string ToString()
        {
            return $"Codice Pratica: {Convert.ToString(Id).PadLeft(5, '0')} | Prestito del: data Inizio | Ammontare: {Ammount} | Contraente: {Contractor.fullName()}";
        }



    }

    
}
