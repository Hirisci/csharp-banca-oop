using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Loan
    {
        private int id = 0;
        public int Id { get; protected set; }
        public User Contractor { get; protected set; }
        public float Amount { get; protected set; }
        public float Installment { get; protected set; }
        public DateTime start { get; protected set; }
        public DateTime end { get; protected set; }

        public Loan( User contractor, float amount, int months)
        {
            Id = ++this.id;
            Contractor = contractor;
            Amount = amount;
            Installment = amount/months;
            this.start = DateTime.Now;
            this.end = start.AddMonths(months);
        }

        public override string ToString()
        {
            return $"Codice Pratica: {Convert.ToString(Id).PadLeft(5, '0')} | Prestito del: {start.ToString("dd/MM/yyyy")} | Ammontare: {Amount} | Contraente: {Contractor.fullName()}";
        }

        public int remainderMonths()
        {
            return (int)DateTime.Now.Subtract(this.start).Days/30;
        }

        public float reminderAmount()
        {

            return this.Amount - (this.Installment * this.remainderMonths())<0 ? 0 : this.Amount - (this.Installment * this.remainderMonths());
        }


    }

    
}
